using System.Collections;
using UnityEngine;

public class SpriteScaling : ActionReleased
{
    protected virtual IEnumerator FlipX(bool xFlipValue) {
        Vector3 scaler = transform.localScale;
        scaler.x = xFlipValue ? -Mathf.Abs(scaler.x) : Mathf.Abs(scaler.x);
        transform.localScale = scaler;
        yield return null;
    }
}