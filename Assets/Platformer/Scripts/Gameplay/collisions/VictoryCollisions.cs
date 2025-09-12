using System;
using UnityEngine;

public class VictoryCollisions : GroundCollisions
{
    protected override Action<GameObject> OnDetected => DetectionHandler;
    protected override void DetectionHandler(GameObject gameObject)
    {
        base.DetectionHandler(gameObject);
        if (gameObject.CompareTag("Goal"))
        {
            ExitGame();
        }
    }
}
