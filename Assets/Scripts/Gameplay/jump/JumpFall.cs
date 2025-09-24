using UnityEngine;

public class JumpFall : JumpTakeoff
{
    protected override void Update()
    {
        base.Update();
        if (isJumping && jumpReleased)
        {
            isJumping = false;
            SetAnimatorParameter(() => isJumping, isJumping, animatorComponent);
            if (rb.linearVelocity.y > 0)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpDeceleration);
            }
        }
    }
}