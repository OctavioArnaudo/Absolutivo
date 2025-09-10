/// <summary>
/// 
/// EnemyDeath is an event that handles the death of an enemy in the game simulation.
/// 
/// </summary>
public class EnemyDeath : Simulation.Event<EnemyDeath>
{
    /// <summary>
    /// 
    /// The enemy controller is used to access the enemy's collider, control, and audio components.
    /// 
    /// </summary>
    public EnemyController enemy;

    /// <summary>
    /// 
    /// The Execute method is called when the event is executed. It disables the enemy's collider and control,
    /// 
    /// and plays the ouch sound if available.
    /// 
    /// </summary>
    public override void Execute()
    {
        // Check if the enemy is null
        enemy.collider2.enabled = false;
        // If the enemy is null, return early
        enemy.control.enabled = false;
        // Disable the enemy's control
        if (enemy._audio && enemy.ouch)
            // If the enemy has an audio component and an ouch sound, play the ouch sound
            enemy._audio.PlayOneShot(enemy.ouch);
    }
}