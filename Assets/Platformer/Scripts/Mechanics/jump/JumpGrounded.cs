using UnityEngine;

public class JumpGrounded : DisplacementTeleport
{
    [SerializeField] protected Vector2 groundCheck;
    [SerializeField] protected float groundCheckRadius = 0.2f;
    protected override void Update()
    {
        base.Update();
        groundCheck = collider2.bounds.center;
        groundCheck.y = collider2.bounds.min.y;
        isGrounded = Physics2D.OverlapCircle(groundCheck, groundCheckRadius, contactFilter2D.layerMask);
        AnimatorService.SetAnimatorParameter(animator, () => isGrounded);
    }
    public virtual void OnDrawGizmo()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck, groundCheckRadius);
    }
}