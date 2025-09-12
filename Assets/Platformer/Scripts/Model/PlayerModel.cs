/// <summary>
/// 
/// PlayerModel is an event that enables player control in the game simulation.
/// 
/// </summary>
public class PlayerModel : Simulation.Event<PlayerModel>
{
    /// <summary>
    /// 
    /// The player model is used to access the player controller and enable input.
    /// 
    /// </summary>
    public PlatformerModel model
    {
        get;
    } = Simulation.GetModel<PlatformerModel>();
    // Check if the player model is null
    public MonoController player
    {
        get;
        protected set;
    }

    /// <summary>
    /// 
    /// The Execute method is called when the event is executed. It enables player control.
    /// 
    /// </summary>
    public override void Execute()
    {
        player = model.player;
    }
}