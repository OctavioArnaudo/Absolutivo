using UnityEngine;

public class JumpDynamic : AnimationSfx
{
    protected override void OnEnable()
    {
        base.OnEnable();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}