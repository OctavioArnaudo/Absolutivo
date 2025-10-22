using UnityEngine;

public class MoveHorizontal : MonoController
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        rb.linearVelocity = new Vector2(displacementInput.x * moveSpeed, rb.linearVelocity.y);
    }
}