using Platformer.Gameplay;
using UnityEngine;

public class PlayerCoinCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Coin"))
		{
			KnapsackInventory inventory = GetComponent<KnapsackInventory>();
			InventoryItem item = GetComponent<InventoryItem>();
			if (inventory != null)
			{
				bool isAdded = inventory.AddItem(item);
			}
			Destroy(collision.gameObject);
		}
	}
}
