using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class GenericController : TempPlatBreak
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public int health = 3;
    public int pain = 0;
    public int coins = 0;
    public int lives = 3;
    public int keys = 0;
    public float platformTimerMax = 5f;

    [Header("Jump Settings")]
    protected int maxJumps = 2;
    protected int jumpsLeft;

    [Header("Player States")]
    public float invulnerableTime = 1.2f;
    public Color invulnerableColor = new Color(1, 1, 1, 0.5f);

    [Header("Wall Slide/Jump")]
    public float wallSlideSpeed = 1.5f;
    public float wallJumpForce = 8f;
    public LayerMask wallLayer;
    private int wallDirX = 0;

    [Header("Dash")]
    public float dashForce = 12f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;

    [Header("Moving Platforms")]
    public MovingPlatformData[] movingPlatforms;

    [Serializable]
    public class MovingPlatformData
    {
        public Transform platform;
        public float moveDistance = 5f;
        public float moveSpeed = 2f;

        [HideInInspector] public Vector3 startPos;
        [HideInInspector] public Vector3 endPos;
        [HideInInspector] public bool movingToEnd = true;
    }

    [Header("Game Over UI")]
    public GameObject gameOverPanel;

    private bool waitingForRebind = false;

    private string lastState = "";
    private float platformTimer;
    private Color originalColor;
    private Vector3 lastCheckpointPosition;
    private Vector3 initialPosition;

    private const float MOVE_THRESHOLD = 0.1f;
    private const float RELOAD_DELAY = 1f;

    protected override Action<GameObject> OnDetected => HandleCollisionOrTrigger;

    protected override void Start()
    {
        base.Start();
        platformTimer = platformTimerMax;
        jumpsLeft = maxJumps;
        lastCheckpointPosition = transform.position;
        initialPosition = transform.position;
        if (spriteRenderer != null)
            originalColor = spriteRenderer.color;

        // Inicializa plataformas móviles
        foreach (var mp in movingPlatforms)
        {
            if (mp.platform != null)
            {
                mp.startPos = mp.platform.position;
                mp.endPos = mp.startPos + Vector3.right * mp.moveDistance;
                mp.movingToEnd = true;
            }
        }

        TriggerOnHealthChanged(health);
        TriggerOnCoinsChanged(coins);
        TriggerOnLivesChanged(lives);
        TriggerOnKeysChanged(keys);

        // Vincula botones auxiliares
        if (respawnButton != null) respawnButton.onClick.AddListener(OnRespawnClicked);
        if (hurtButton != null) hurtButton.onClick.AddListener(OnHurtClicked);

        // Inicializa el menú de Game Over
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        UpdateKeyBindingUI();

    }

    protected override void Update()
    {
        base.Update();
        if (isGameOver)
        {

            // Permite reasignar teclas si está esperando input
            if (waitingForRebind)
                ListenForRebind();

            return;
        }

        // Permite reasignar teclas si está esperando input
        if (waitingForRebind)
        {
            ListenForRebind();
            return;
        }

        HandleInput();
        UpdateAnimatorParameters();
        HandlePlatformTimer();
        PlatformTiming();
        CheckWallSlide();
        UpdateMovingPlatforms();
    }

    // --- Botones auxiliares ---
    void OnRespawnClicked()
    {
        // Reubica al jugador en la posición inicial y reinicia variables clave
        transform.position = initialPosition;
        health = 3;
        lives = 3;
        keys = 0;
        coins = 0;
        isGameOver = false;
        enabled = true;
        isDead = false;
        AnimatorService.SetAnimatorParameter(animator, () => isDead);
        TriggerOnHealthChanged(health);
        TriggerOnLivesChanged(lives);
        TriggerOnCoinsChanged(coins);
        TriggerOnKeysChanged(keys);
        ShowInfo("¡Respawn manual!");
    }

    void OnHurtClicked()
    {
        health = Mathf.Max(0, health - 1);
        SetState("hurt", hurtClip);
        isHurt = true;
        AnimatorService.SetAnimatorParameter(animator, () => isHurt);
        TriggerOnHealthChanged(health);
        ShowInfo("¡Daño recibido!");
    }

    void ShowInfo(string msg)
    {
        if (infoText != null)
            infoText.text = msg;
    }

    // --- Movimiento de plataformas móviles ---
    void UpdateMovingPlatforms()
    {
        foreach (var mp in movingPlatforms)
        {
            if (mp.platform == null) continue;
            if (mp.movingToEnd)
            {
                mp.platform.position = Vector3.MoveTowards(mp.platform.position, mp.endPos, mp.moveSpeed * Time.deltaTime);
                if (Vector3.Distance(mp.platform.position, mp.endPos) < 0.01f)
                    mp.movingToEnd = false;
            }
            else
            {
                mp.platform.position = Vector3.MoveTowards(mp.platform.position, mp.startPos, mp.moveSpeed * Time.deltaTime);
                if (Vector3.Distance(mp.platform.position, mp.startPos) < 0.01f)
                    mp.movingToEnd = true;
            }
        }
    }

    void HandleInput()
    {
        float mInput = displacementInput.x;

        // --- Flip del sprite según dirección ---
        if (mInput < -MOVE_THRESHOLD)
            spriteRenderer.flipX = true;
        else if (mInput > MOVE_THRESHOLD)
            spriteRenderer.flipX = false;

        if (!isDashing)
            rb.linearVelocity = new Vector2(mInput * speed, rb.linearVelocity.y);

        if (health <= 0)
        {
            SetState("death", deathClip);
            isDead = true;
            AnimatorService.SetAnimatorParameter(animator, () => isDead);
            return;
        }

        if (victoryPressed)
        {
            SetState("victory", victoryClip);
            isVictorious = true;
            AnimatorService.SetAnimatorParameter(animator, () => isVictorious);
            return;
        }
        if (hurtPressed)
        {
            SetState("hurt", hurtClip);
            isHurt = true;
            AnimatorService.SetAnimatorParameter(animator , () => isHurt);
            pain++;
            return;
        }
        if (defeatPressed)
        {
            SetState("defeat", defeatClip);
            isDefeated = true;
            AnimatorService.SetAnimatorParameter(animator , () => isDefeated);
            return;
        }
        if (spawnPressed)
        {
            SetState("spawn", spawnClip);
            isRespawning = true;
            AnimatorService.SetAnimatorParameter(animator , () => isRespawning);
            return;
        }

        // Dash (ahora con tecla reasignable)
        if (canDash && !isDashing)
        {
            StartCoroutine(Dash(mInput));
        }

        // Wall Jump
        if (isWallSliding)
        {
            rb.linearVelocity = new Vector2(-wallDirX * speed, wallJumpForce);
            SetState("jump", jumpClip);
            isJumping = true;
            AnimatorService.SetAnimatorParameter(animator, () => isJumping);
            jumpsLeft = maxJumps - 1;

            // Flip según dirección del wall jump
            if (wallDirX != 0)
                spriteRenderer.flipX = wallDirX > 0 ? false : true;

            return;
        }

        // Movimiento y animaciones principales
        if (isGrounded)
        {
            isLanding = false;
            AnimatorService.SetAnimatorParameter(animator, () => isLanding);

            if (Mathf.Abs(mInput) > MOVE_THRESHOLD)
            {
                if (!isDashing && displacementInput.x < 0)
                {
                    SetState("run", runClip);
                    isRunning = true;
                    AnimatorService.SetAnimatorParameter(animator, () => isRunning);
                    isWalking = false;
                    AnimatorService.SetAnimatorParameter(animator, () => isWalking);
                }
                else
                {
                    SetState("walk", walkClip);
                    isWalking = true;
                    AnimatorService.SetAnimatorParameter(animator, () => isWalking);
                    isRunning = false;
                    AnimatorService.SetAnimatorParameter(animator, () => isRunning);
                }
            }
            else
            {
                SetState("idle", idleClip);
                isWalking = false;
                AnimatorService.SetAnimatorParameter(animator, () => isWalking);
                isRunning = false;
                AnimatorService.SetAnimatorParameter(animator, () => isRunning);
            }
        }

        // Doble salto (ahora con tecla reasignable)
        if (jumpsLeft > 0 && jumpPressed && !isWallSliding)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            SetState("jump", jumpClip);
            isJumping = true;
            AnimatorService.SetAnimatorParameter(animator, () => isJumping);
            jumpsLeft--;

            // Flip según dirección del salto (si se está moviendo)
            if (mInput < -MOVE_THRESHOLD)
                spriteRenderer.flipX = true;
            else if (mInput > MOVE_THRESHOLD)
                spriteRenderer.flipX = false;
        }

    }

    void UpdateAnimatorParameters()
    {
        float moveInput = displacementInput.x;
        animator.SetFloat("velocityX", Mathf.Abs(moveInput));
        animator.SetFloat("velocityY", rb.linearVelocity.y);
        AnimatorService.SetAnimatorParameter(animator, () => isGrounded);
        isDead = health <= 0;
        AnimatorService.SetAnimatorParameter(animator, () => isDead);
    }

    void HandlePlatformTimer()
    {
        if (!isGrounded)
        {
            platformTimer -= Time.deltaTime;
            if (platformTimer <= 0)
            {
                Die();
            }
        }
        else
        {
            platformTimer = platformTimerMax;
        }
    }

    protected override void HandleCollisionOrTrigger(GameObject obj)
    {
        base.HandleCollisionOrTrigger(obj);
        // Plataforma indestructible
        if (obj.CompareTag("Ground") || obj.CompareTag("MovingGround"))
        {
            bool wasGrounded = isGrounded;
            isGrounded = true;
            jumpsLeft = maxJumps;

            if (!wasGrounded)
            {
                isLanding = true;
                AnimatorService.SetAnimatorParameter(animator, () => isLanding);
                isJumping = false;
                AnimatorService.SetAnimatorParameter(animator, () => isJumping);
                SetState("land", landClip);
            }
        }
        // Moneda
        if (obj.CompareTag("Coin"))
        {
            coins++;
            PlayObjectAudio(obj);
            if (coinClip != null && audioSource != null) audioSource.PlayOneShot(coinClip);
            Destroy(obj);
            TriggerOnCoinsChanged(coins);
            TriggerOnAchievementUnlocked("Moneda");
        }
        // Enemigo
        if (obj.CompareTag("Enemy"))
        {
            // Rebote sobre enemigo
            if (rb.linearVelocity.y < 0 && transform.position.y > obj.transform.position.y + 0.2f)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * 0.8f);
                PlayObjectAudio(obj);
                if (enemyClip != null && audioSource != null) audioSource.PlayOneShot(enemyClip);
                Destroy(obj);
                TriggerOnAchievementUnlocked("Enemigo");
            }
            else if (!isInvulnerable)
            {
                pain++;
                health--;
                PlayObjectAudio(obj);
                if (enemyClip != null && audioSource != null) audioSource.PlayOneShot(enemyClip);
                TriggerOnHealthChanged(health);
                if (health <= 0)
                {
                    Die();
                }
                else
                {
                    SetState("hurt", hurtClip);
                    isHurt = true;
                    AnimatorService.SetAnimatorParameter(animator, () => isHurt);
                    StartCoroutine(Invulnerability());
                }
            }
        }
        // Power-ups
        if (obj.CompareTag("BuffSpeed"))
        {
            PlayObjectAudio(obj);
            if (powerUpClip != null && audioSource != null) audioSource.PlayOneShot(powerUpClip);
            if (speedPowerUpCoroutine != null) StopCoroutine(speedPowerUpCoroutine);
            speedPowerUpCoroutine = StartCoroutine(SpeedPowerUp(2f, 5f));
            Destroy(obj);
        }
        if (obj.CompareTag("BuffJump"))
        {
            PlayObjectAudio(obj);
            if (powerUpClip != null && audioSource != null) audioSource.PlayOneShot(powerUpClip);
            if (jumpPowerUpCoroutine != null) StopCoroutine(jumpPowerUpCoroutine);
            jumpPowerUpCoroutine = StartCoroutine(JumpPowerUp(1.5f, 5f));
            Destroy(obj);
        }
        // Checkpoint
        if (obj.CompareTag("CheckPoint"))
        {
            lastCheckpointPosition = obj.transform.position;
            PlayObjectAudio(obj);
            if (checkpointClip != null && audioSource != null) audioSource.PlayOneShot(checkpointClip);
            TriggerOnAchievementUnlocked("Checkpoint");
        }
        // Llave
        if (obj.CompareTag("Key"))
        {
            keys++;
            PlayObjectAudio(obj);
            if (keyClip != null && audioSource != null) audioSource.PlayOneShot(keyClip);
            Destroy(obj);
            TriggerOnKeysChanged(keys);
        }
        // Puerta
        if (obj.CompareTag("Door"))
        {
            if (keys > 0)
            {
                keys--;
                PlayObjectAudio(obj);
                if (doorClip != null && audioSource != null) audioSource.PlayOneShot(doorClip);
                TriggerOnKeysChanged(keys);
                Destroy(obj);
            }
        }
        // Victoria
        if (obj.CompareTag("Victory"))
        {
            PlayObjectAudio(obj);
            SetState("victory", victoryClip);
            isVictorious = true;
            AnimatorService.SetAnimatorParameter(animator, () => isVictorious);
            TriggerOnAchievementUnlocked("Victoria");
        }
    }

    protected override void OnCollisionExit2D(Collision2D collision)
    {
        base.OnCollisionExit2D(collision);
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("TempPlatform") ||
            collision.gameObject.CompareTag("MovingGround") ||
            collision.gameObject.CompareTag("MovingTempPlatform"))
        {
            isGrounded = false;
            AnimatorService.SetAnimatorParameter(animator, () => isGrounded);
            isLanding = false;
            AnimatorService.SetAnimatorParameter(animator, () => isLanding);
        }
    }

    void Die()
    {
        SetState("death", deathClip);
        isDead = true;
        AnimatorService.SetAnimatorParameter(animator, () => isDead);
        enabled = false;
        rb.linearVelocity = Vector2.zero;
        lives--;
        TriggerOnLivesChanged(lives);

        if (lives > 0)
        {
            StartCoroutine(RespawnAfterDelay(RELOAD_DELAY));
        }
        else
        {
            isGameOver = true;
            SetState("defeat", defeatClip);
            ShowGameOverMenu();
        }
    }

    IEnumerator RespawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        transform.position = lastCheckpointPosition;
        health = 3;
        isDead = false;
        AnimatorService.SetAnimatorParameter(animator, () => isDead);
        enabled = true;
        isGameOver = false;
        TriggerOnHealthChanged(health);
    }

    IEnumerator SpeedPowerUp(float multiplier, float duration)
    {
        float originalSpeed = speed;
        speed *= multiplier;
        yield return new WaitForSeconds(duration);
        speed = originalSpeed;
    }

    IEnumerator JumpPowerUp(float multiplier, float duration)
    {
        float originalJump = jumpForce;
        jumpForce *= multiplier;
        yield return new WaitForSeconds(duration);
        jumpForce = originalJump;
    }

    IEnumerator Invulnerability()
    {
        isInvulnerable = true;
        if (spriteRenderer != null)
        {
            float t = 0f;
            while (t < invulnerableTime)
            {
                spriteRenderer.color = invulnerableColor;
                yield return new WaitForSeconds(0.1f);
                spriteRenderer.color = originalColor;
                yield return new WaitForSeconds(0.1f);
                t += 0.2f;
            }
            spriteRenderer.color = originalColor;
        }
        yield return new WaitForSeconds(invulnerableTime);
        isInvulnerable = false;
    }

    IEnumerator Dash(float moveInput)
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0;
        rb.linearVelocity = new Vector2((moveInput != 0 ? Mathf.Sign(moveInput) : transform.localScale.x) * dashForce, 0f);
        if (dashClip != null && audioSource != null) audioSource.PlayOneShot(dashClip);
        yield return new WaitForSeconds(dashDuration);
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }

    void CheckWallSlide()
    {
        isTouchingWall = Physics2D.OverlapCircle(transform.position + Vector3.right * 0.5f, 0.1f, wallLayer) ||
                         Physics2D.OverlapCircle(transform.position + Vector3.left * 0.5f, 0.1f, wallLayer);

        wallDirX = (Physics2D.OverlapCircle(transform.position + Vector3.right * 0.5f, 0.1f, wallLayer)) ? 1 :
                   (Physics2D.OverlapCircle(transform.position + Vector3.left * 0.5f, 0.1f, wallLayer)) ? -1 : 0;

        isWallSliding = !isGrounded && isTouchingWall && rb.linearVelocity.y < 0;
        if (isWallSliding)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -wallSlideSpeed);
        }
    }

    void SetState(string state, AudioClip clip)
    {
        string animName = "Player-" + state;
        if (lastState == animName) return;
        lastState = animName;

        if (animator != null && animator.runtimeAnimatorController != null)
        {
            if (animator.HasState(0, Animator.StringToHash(animName)))
            {
                animator.Play(animName);
            }
        }
        if (audioSource != null && clip != null)
        {
            if (audioSource.clip != clip || !audioSource.isPlaying)
            {
                audioSource.clip = clip;
                audioSource.Play();
            }
        }
    }

    // --- Game Over Menu ---
    void ShowGameOverMenu()
    {
        isGameOver = true;
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void HideGameOverMenu()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void ListenForRebind()
    {
        foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
        {
            if (jumpPressed)
            {
                waitingForRebind = false;
                UpdateKeyBindingUI();
                ShowInfo("Tecla reasignada.");
                break;
            }
        }
    }

    void UpdateKeyBindingUI()
    {
        if (jumpKeyText != null)
            jumpKeyText.text = "Salto: " + jumpAction.ToString();
    }
}
