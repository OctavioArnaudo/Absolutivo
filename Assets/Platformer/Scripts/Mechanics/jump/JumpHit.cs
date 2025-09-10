using UnityEngine;

public class JumpHit : JumpGrounded
{
    protected override void Update()
    {
        base.Update();
        if (isGrounded && jumpPressed)
        {
            isJumping = true;
            AnimatorService.SetAnimatorParameter(animator, () => isJumping);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxJumpSpeed);
        }
    }
}