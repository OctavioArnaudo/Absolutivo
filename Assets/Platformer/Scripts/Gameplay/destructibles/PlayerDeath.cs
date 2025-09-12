using Platformer.Gameplay;

/// <summary>
/// 
/// PlayerDeath is an event that handles the player's death in the game simulation.
/// 
/// </summary>
public class PlayerDeath : PlayerModel
{

    public HealthModel health
    {
        get;
        protected set;
    }

    /// <summary>
    /// 
    /// The Execute method is called when the event is executed. It checks if the player is alive,
    /// 
    /// disables the player's collider and control, plays the ouch sound, and triggers the death animation.
    ///
    /// </summary>
    public override void Execute()
    {
        base.Execute();
        // If the player model is null, return early
        if (player.isAlive)
        {
            // Disable the player's collider and control, play the ouch sound, and trigger the death animation
            health.Die();
            // Disable the player's collider
            model.virtualCamera.Follow = null;
            // Disable the camera follow
            model.virtualCamera.LookAt = null;
            // player.collider.enabled = false;
            // Disable the player's collider

            // Disable the player's control
            //if (player.audioSource && player.ouchAudio)
                // If the player has an audio source and an ouch sound, play the ouch sound
                //player.audioSource.PlayOneShot(player.ouchAudio);
            // Play the ouch sound
            //player.animator.SetTrigger("hurt");
            // Trigger the hurt animation
            // Set the dead animation state to true
            //AnimatorService.SetAnimatorParameter(player.animator, () => dead);
            // Set the dead animation state to true
            Simulation.Schedule<PlayerSpawn>(2);
        }
    }
}