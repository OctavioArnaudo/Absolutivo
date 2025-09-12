using UnityEngine;

[
    RequireComponent(
        typeof(Collider2D)
    )
]
public class BaseCollider2D : BaseAudioSource
{
    /*internal new*/
    [SerializeField] protected Collider2D collider2;

    protected override void Awake()
    {
        base.Awake();
        collider2 = GetComponent<Collider2D>();
    }
}