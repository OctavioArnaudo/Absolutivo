using UnityEngine;

public class JumpKinematic : JumpDynamic
{
    protected override void OnDisable()
    {
        base.OnDisable();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
}