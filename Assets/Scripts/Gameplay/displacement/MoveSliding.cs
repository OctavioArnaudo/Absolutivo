using System.Collections;
using UnityEngine;

public class MoveSliding : MoveDashing
{
    protected virtual IEnumerator WallSlide()
    {
        isTouchingWall = Physics2D.OverlapCircle(transform.position + Vector3.right * 0.5f, 0.1f, layerMask) ||
                         Physics2D.OverlapCircle(transform.position + Vector3.left * 0.5f, 0.1f, layerMask);

        wallDirX = Physics2D.OverlapCircle(transform.position + Vector3.right * 0.5f, 0.1f, layerMask) ? 1 :
                   Physics2D.OverlapCircle(transform.position + Vector3.left * 0.5f, 0.1f, layerMask) ? -1 : 0;

        isWallSliding = !isGrounded && isTouchingWall && rb.linearVelocity.y < 0;

        if (isWallSliding)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -wallSlideSpeed);
        }

        yield return null;
    }
}