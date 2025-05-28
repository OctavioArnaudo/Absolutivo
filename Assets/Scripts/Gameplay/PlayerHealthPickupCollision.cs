using Platformer.Gameplay;
using UnityEngine;

public class PlayerHealthPickupCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("HealthPickup"))
		{
			PlayerHealth playerHealth = GetComponent<PlayerHealth>();
			if (playerHealth != null)
			{
				playerHealth.Heal(20); // Suma 20 de vida
			}
			Destroy(collision.gameObject); // Elimina el objeto de salud
		}
	}
}
