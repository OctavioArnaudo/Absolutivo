using UnityEngine;

public class DisplacementImpulse : AudioPlay
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        rb.linearVelocity = new Vector2(displacementInput.x * maxMoveSpeed, rb.linearVelocity.y);
    }
}