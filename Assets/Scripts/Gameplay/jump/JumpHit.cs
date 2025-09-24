using UnityEngine;

public class JumpHit : JumpGrounded
{
    protected override void Update()
    {
        base.Update();
        if (isGrounded && jumpPressed)
        {
            isJumping = true;
            SetAnimatorParameter(() => isJumping, isJumping, animatorComponent);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxJumpSpeed);
        }
    }
}