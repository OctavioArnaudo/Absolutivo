/// <summary>
/// 
/// PlayerSpawn is an event that handles the player's respawn action in the game simulation.
/// 
/// </summary>
public class PlayerSpawn : Simulation.Event<PlayerSpawn>
{
    /// <summary>
    /// 
    /// The model is used to access the player controller, camera, and other game components.
    /// 
    /// </summary>
    PlatformerModel model = Simulation.GetModel<PlatformerModel>();

    /// <summary>
    /// 
    /// The Execute method is called when the event is executed. It enables the player's collider, disables control,
    /// 
    /// plays the respawn audio, increments the player's health, teleports the player to the spawn point,
    /// 
    /// resets the jump state, and updates the camera to follow the player.
    ///
    /// </summary>
    public override void Execute()
    {
        // Check if the player model is null
        var player = model.player;
        var health = model.health;
        // If the player model is null, return early
        player.enabled = true;
        // Enable the player's collider
        // Disable the player's control
        //if (player.audioSource && player.respawnAudio)
            // If the player has an audio source and a respawn sound, play the respawn sound
            //player.audioSource.PlayOneShot(player.respawnAudio);
        // Play the respawn sound
        health.Increment();
        // Increment the player's health
        // Teleport the player to the spawn point
        // Reset the player's jump state to grounded
    }
}