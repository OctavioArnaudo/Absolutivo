using System;
using UnityEngine;

public class SpriteFacing : ActionReleased
{
    protected Action<bool> flipX;

    protected override void Awake()
    {
        base.Awake();
        flipX = (bool xFlipValue) => {
            spriteRenderer.flipX = xFlipValue;
        };
    }

    public void ScaleX(bool xFlipValue)
    {
        Vector3 scaler = transform.localScale;
        scaler.x = xFlipValue ? -Mathf.Abs(scaler.x) : Mathf.Abs(scaler.x);
        transform.localScale = scaler;
    }
}