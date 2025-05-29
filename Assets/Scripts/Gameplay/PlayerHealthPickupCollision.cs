using Platformer.Mechanics;
using UnityEngine;

public class PlayerHealthPickupCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("HealthPickup"))
		{
			Health playerHealth = GetComponent<Health>();
			if (playerHealth != null)
			{
				playerHealth.TakeHeal(20); // Suma 20 de vida
			}
			Destroy(collision.gameObject); // Elimina el objeto de salud
		}
	}
}
