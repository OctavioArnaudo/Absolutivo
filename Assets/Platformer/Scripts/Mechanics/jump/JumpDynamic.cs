using UnityEngine;

public class JumpDynamic : JumpCoroutine
{
    public override void Enable()
    {
        OnEnable();
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}