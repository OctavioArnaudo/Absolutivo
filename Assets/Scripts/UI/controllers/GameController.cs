using UnityEngine;

/// <summary>
/// 
/// GameController is a MonoBehaviour that manages the game simulation and provides access to the game model.
/// 
/// </summary>
public class GameController : MonoBehaviour
{
    /// <summary>
    /// 
    /// The singleton instance of the GameController.
    /// 
    /// </summary>
    public static GameController Instance
    {
        get;
        private set;
    }

    /// <summary>
    /// 
    /// The model that contains the game state and mechanics.
    /// 
    /// </summary>
    public PlatformerModel model = Simulation.GetModel<PlatformerModel>();
    //This model field is public and can be therefore be modified in the 
    //inspector.
    //The reference actually comes from the InstanceRegister, and is shared
    //through the simulation and events. Unity will deserialize over this
    //shared reference when the scene loads, allowing the model to be
    //conveniently configured inside the inspector.

    /// <summary>
    /// 
    /// The simulation that manages the game events and mechanics.
    /// 
    /// </summary>
    void OnEnable()
    {
        // Ensure that only one instance of GameController exists
        Instance = this;
    }

    /// <summary>
    /// 
    /// Called when the GameController is disabled. It sets the Instance to null if it is the current instance.
    /// 
    /// </summary>
    void OnDisable()
    {
        // Set Instance to null when this GameController is disabled
        if (Instance == this) Instance = null;
    }

    /// <summary>
    /// 
    /// Update is called once per frame. It ticks the simulation if this GameController is the current instance.
    /// 
    /// </summary>
    void Update()
    {
        // If this GameController is the current instance, tick the simulation
        if (Instance == this) Simulation.Tick();
    }
}