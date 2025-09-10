using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraButtons : JumpLayer
{

    public Button respawnButton;
    public Button dieButton;
    public Button victoryButton;
    public Button hurtButton;

    public Button restartButton;
    public Button exitButton;
    public Button rebindJumpButton;
    public Button rebindDashButton;

    protected override void Awake()
    {
        base.Awake();
        if (restartButton != null) restartButton.onClick.AddListener(RestartGame);

        if (exitButton != null) exitButton.onClick.AddListener(ExitGame);
    }

    protected virtual void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    protected virtual void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}