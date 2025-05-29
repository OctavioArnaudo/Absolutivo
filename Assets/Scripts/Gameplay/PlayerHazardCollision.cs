using Platformer.Mechanics;
using UnityEngine;

public class PlayerHazardCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Hazard"))
		{
			Health playerHealth = GetComponent<Health>();
			if (playerHealth != null)
			{
				playerHealth.Die(); // Mata al jugador instantáneamente
			}
		}
	}
}
