using System.Collections;
using UnityEngine;

public class MoveDashing : MonoController
{
    protected virtual IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0;
        rb.linearVelocity = new Vector2((displacementInput.x != 0 ? Mathf.Sign(displacementInput.x) : transform.localScale.x) * dashForce, 0f);
        if (dashClip != null && Source != null) Source.PlayOneShot(dashClip);
        yield return new WaitForSeconds(dashDuration);
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
}