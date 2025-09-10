using UnityEngine;

[
    RequireComponent(
        typeof(SpriteRenderer)
    )
]
public class BaseSpriteRenderer : BaseRigidbody2D
{
    [SerializeField] protected SpriteRenderer spriteRenderer;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}