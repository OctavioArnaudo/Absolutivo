using UnityEngine;

/// <summary>
/// Marks a trigger as a VictoryZone, usually used to end the current game level.
/// </summary>
public class VictoryZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        var p = collider.gameObject.GetComponent<MonoController>();
        if (p != null)
        {
            var ev = Simulation.Schedule<PlayerEnteredVictoryZone>();
            ev.victoryZone = this;
        }
    }
}