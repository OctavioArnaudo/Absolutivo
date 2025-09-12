using UnityEngine;

[
    RequireComponent(
        typeof(Animator)
    )
]
public class BaseAnimator : MonoComponent
{
    [SerializeField] protected Animator animator;
    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }
}