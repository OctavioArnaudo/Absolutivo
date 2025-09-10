using UnityEngine;

public class AnimationParameters : HealthCurrent
{
    [SerializeField] protected bool canDash;
    [SerializeField] protected bool defeatPressed;
    [SerializeField] protected bool hurtPressed;
    [SerializeField] public bool isAlive => currentHP > 0;
    [SerializeField] protected bool isDashing;
    [SerializeField] protected bool isDead;
    [SerializeField] protected bool isDefeated;
    [SerializeField] protected bool isGameOver;
    [SerializeField] protected bool isGrounded;
    [SerializeField] protected bool isHurt;
    [SerializeField] protected bool isInFlight;
    [SerializeField] protected bool isInvulnerable;
    [SerializeField] protected bool isJumping;
    [SerializeField] protected bool isLanded;
    [SerializeField] protected bool isLanding;
    [SerializeField] protected bool isPreparingToJump;
    [SerializeField] protected bool isRespawning;
    [SerializeField] protected bool isRunning;
    [SerializeField] protected bool isTouchingWall;
    [SerializeField] protected bool isVictorious;
    [SerializeField] protected bool isWalking;
    [SerializeField] protected bool isWallSliding;
    [SerializeField] protected bool jumpPressed;
    [SerializeField] protected bool jumpReleased;
    [SerializeField] protected bool justLanded;
    [SerializeField] protected bool spawnPressed;
    [SerializeField] protected bool victoryPressed;
}