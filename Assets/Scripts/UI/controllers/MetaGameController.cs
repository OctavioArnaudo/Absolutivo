using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// The MetaGameController is responsible for switching control between the high level
/// contexts of the application, eg the Main Menu and Gameplay systems.
/// </summary>
public class MetaGameController : MonoBehaviour
{
    /// <summary>
    /// The main UI object which used for the menu.
    /// </summary>
    public InitPanel mainMenu;

    /// <summary>
    /// A list of canvas objects which are used during gameplay (when the main ui is turned off)
    /// </summary>
    public Canvas[] gamePlayCanvasii;

    /// <summary>
    /// The game controller.
    /// </summary>
    public GameController gameController;

    /// <summary>
    /// 
    /// A flag to indicate whether the main menu is currently shown or not.
    /// 
    /// </summary>
    bool showMainCanvas = false;
    /// <summary>
    /// 
    /// The input action for toggling the main menu.
    /// 
    /// </summary>
    private InputAction m_MenuAction;

    /// <summary>
    /// 
    /// Called when the script is enabled. It initializes the main menu state and finds the input action for toggling the menu.
    /// 
    /// </summary>
    void OnEnable()
    {
        // Initialize the main menu state
        _ToggleMainMenu(showMainCanvas);
        // Find the input action for toggling the main menu
        m_MenuAction = InputSystem.actions.FindAction("Player/Menu");
    }

    /// <summary>
    /// Turn the main menu on or off.
    /// </summary>
    /// <param name="show"></param>
    public void ToggleMainMenu(bool show)
    {
        // If the current state is the same as the requested state, do nothing
        if (this.showMainCanvas != show)
        {
            // If the game controller is not null, set the game state to the requested state
            _ToggleMainMenu(show);
        }
    }

    /// <summary>
    /// 
    /// Internal method to toggle the main menu on or off.
    /// 
    /// </summary>
    void _ToggleMainMenu(bool show)
    {
        // If the requested state is the same as the current state, do nothing
        if (show)
        {
            // If the game controller is not null, set the game state to the requested state
            Time.timeScale = 0;
            // Pause the game
            mainMenu.gameObject.SetActive(true);
            // Set the main menu to active
            foreach (var i in gamePlayCanvasii) i.gameObject.SetActive(false);
        }
        else
        {
            // If the requested state is false, set the game state to the requested state
            Time.timeScale = 1;
            // Resume the game
            mainMenu.gameObject.SetActive(false);
            // Set the main menu to inactive
            foreach (var i in gamePlayCanvasii) i.gameObject.SetActive(true);
        }
        // Set the active state of the game play canvas objects
        this.showMainCanvas = show;
    }

    /// <summary>
    /// 
    /// Called every frame to check for input actions.
    /// 
    /// </summary>
    void Update()
    {
        // If the game controller is null, return early
        if (m_MenuAction.WasPressedThisFrame())
        {
            // If the menu action was pressed, toggle the main menu
            ToggleMainMenu(show: !showMainCanvas);
        }
    }

}