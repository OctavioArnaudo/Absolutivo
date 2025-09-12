using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollisions : MonoController
{
    protected virtual void DetectionHandler(GameObject gameObject)
    {
        if (gameObject.CompareTag("Ground"))
        {
            RestartGame();
        }
    }
}
