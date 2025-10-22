using System.Collections;

public class SpriteFacing : SpriteScaling
{
    protected new IEnumerator FlipX(bool xFlipValue)
    {
        sr.flipX = xFlipValue;
        yield return null;
    }
}