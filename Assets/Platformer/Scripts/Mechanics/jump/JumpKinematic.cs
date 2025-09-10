using UnityEngine;

public class JumpKinematic : JumpDynamic
{
    public override void Disable()
    {
        OnDisable();
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
}