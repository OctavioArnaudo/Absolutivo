using System;
using UnityEngine;

[Serializable]
public class InitAnimator : Init3D
{
    [AnimatorModel("AttackType")][SerializeField][Range(0F, 2F)] protected int attackType = 0; // 0 = ninguno, 1 = melee, 2 = ranged
    [AnimatorModel("CanDash")][SerializeField] protected bool canDash;
    [AnimatorModel("DashCooldown")][SerializeField] protected float dashCooldown;
    [AnimatorModel("DashDuration")][SerializeField] protected float dashDuration;
    [AnimatorModel("DashForce")][SerializeField] protected float dashForce;
    [AnimatorModel("EmitOn")][SerializeField] protected bool emitOnCharacterDeath = true;
    [AnimatorModel("Health")][SerializeField] protected int currentHP = 1;
    [AnimatorModel("Health")][SerializeField] protected int maxHP = 1;
    [AnimatorModel("HurtPressed")][SerializeField] protected bool hurtPressed;
    [AnimatorModel("IsAlive")][SerializeField] protected bool isAlive;
    [AnimatorModel("IsAttacking")][SerializeField] protected bool isAttacking = false;
    [AnimatorModel("IsBroken")][SerializeField] protected bool isBroken;
    [AnimatorModel("IsDashing")][SerializeField] protected bool isDashing;
    [AnimatorModel("IsDead")][SerializeField] protected bool isDead = false;
    [AnimatorModel("IsDefeated")][SerializeField] protected bool isDefeated;
    [AnimatorModel("IsGameOver")][SerializeField] protected bool isGameOver;
    [AnimatorModel("IsGrounded")][SerializeField] protected bool isGrounded;
    [AnimatorModel("IsHurt")][SerializeField] protected bool isHurt = false;
    [AnimatorModel("IsIdle")][SerializeField] protected bool isIdle = false;
    [AnimatorModel("IsInFlight")][SerializeField] protected bool isInFlight;
    [AnimatorModel("IsInPursuit")][SerializeField] protected bool isInPursuit = false;
    [AnimatorModel("IsInvulnerable")][SerializeField] protected bool isInvulnerable;
    [AnimatorModel("IsJumping")][SerializeField] protected bool isJumping;
    [AnimatorModel("IsLanded")][SerializeField] protected bool isLanded;
    [AnimatorModel("IsLanding")][SerializeField] protected bool isLanding;
    [AnimatorModel("IsPatrolling")][SerializeField] protected bool isPatrolling = true;
    [AnimatorModel("IsPreparingToJump")][SerializeField] protected bool isPreparingToJump;
    [AnimatorModel("IsRespawning")][SerializeField] protected bool isRespawning;
    [AnimatorModel("IsRunning")][SerializeField] protected bool isRunning;
    [AnimatorModel("IsTouchingWall")][SerializeField] protected bool isTouchingWall = false;
    [AnimatorModel("IsVictorious")][SerializeField] protected bool isVictorious;
    [AnimatorModel("IsWalking")][SerializeField] protected bool isWalking;
    [AnimatorModel("IsWallSliding")][SerializeField] protected bool isWallSliding = false;
    [AnimatorModel("JumpDeceleration")][SerializeField][Range(1F, 9.81F)] protected float jumpDeceleration = 2F;
    [AnimatorModel("JumpPressed")][SerializeField] protected bool jumpPressed = false;
    [AnimatorModel("JumpReleased")][SerializeField] protected bool jumpReleased = false;
    [AnimatorModel("JumpSpeed")][SerializeField][Range(2F, 6F)] protected float jumpSpeed = 6F;
    [AnimatorModel("LifeTime")][SerializeField] protected float lifetime = 2f;
    [AnimatorModel("MenuShown")][SerializeField] protected bool menuShown = false;
    [AnimatorModel("MoveAcceleration")][SerializeField][Range(2F, 15F)] protected float moveAcceleration = 3F;
    [AnimatorModel("MoveSpeed")][SerializeField][Range(2F, 6F)] protected float moveSpeed = 6F;
    [AnimatorModel("SpawnDelay")][SerializeField] protected float spawnDelay = 1f;
    [AnimatorModel("SpawnDistance")][SerializeField] protected float spawnDistance = 0F;
    [AnimatorModel("SpawnPressed")][SerializeField] protected bool spawnPressed;
    [AnimatorModel("SpawnSize")][SerializeField] protected int spawnSize = 1;
    [AnimatorModel("SpawnSpeed")][SerializeField] protected float spawnSpeed = 10f;
    [AnimatorModel("WallDirX")][SerializeField] protected int wallDirX;
    [AnimatorModel("WallSlideSpeed")][SerializeField] protected float wallSlideSpeed = 2F;

    protected string currentState = "";

    protected override void Update()
    {
        base.Update();
        isAlive = currentHP > 0;
    }

    /// <summary>
    /// 
    /// Called when the script is first loaded or when the game object is instantiated.
    /// 
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        // Initialize the current HP to the maximum HP.
        currentHP = maxHP;
    }
}