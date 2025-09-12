using UnityEngine;

/// <summary>
/// 
/// DeathZone is a MonoBehaviour that detects when a player enters a death zone in the game.
/// 
/// </summary>
public class DeathZone : MonoBehaviour
{
    /// <summary>
    /// 
    /// The OnTriggerEnter2D method is called when a collider enters the trigger collider attached to the death zone.
    /// 
    /// </summary>
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if the collider is a player controller
        var p = collider.gameObject.GetComponent<MonoController>();
        // If the collider is not a player controller, return early
        if (p != null)
        {
            // If the collider is a player controller, schedule the PlayerEnteredDeathZone event
            var ev = Simulation.Schedule<PlayerDeath>(0);
            // Set the deathzone property of the event to this death zone
        }
    }
}