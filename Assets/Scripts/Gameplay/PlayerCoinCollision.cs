using Platformer.Gameplay;
using UnityEngine;

public class PlayerCoinCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Coin"))
		{
			PlayerInventory inventory = GetComponent<PlayerInventory>();
			InventoryItem item = GetComponent<InventoryItem>();
			if (inventory != null)
			{
				bool isAdded = inventory.AddItem(item); // Suma una moneda al inventario
			}
			Destroy(collision.gameObject); // Elimina la moneda
		}
	}
}
