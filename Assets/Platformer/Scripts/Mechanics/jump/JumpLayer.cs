using UnityEngine;

public class JumpLayer : JumpKinematic
{
    protected override void Start()
    {
        base.Start();
        contactFilter2D.useTriggers = false;
        contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));
        contactFilter2D.useLayerMask = true;
    }
}