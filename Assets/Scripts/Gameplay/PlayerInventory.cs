using UnityEngine;
using System.Collections.Generic;
using System;

namespace Platformer.Gameplay
{
	public class PlayerInventory : MonoBehaviour
	{
		public static PlayerInventory instance;
		public event Action<PlayerInventory> OnInventoryChanged;

		[Header("Inventory Settings")]
		[SerializeField] private int inventoryCapacity = 3;

		public List<CoinsItem> items = new List<CoinsItem> ();

		void Awake()
		{
			if (instance == null)
			{
				Debug.LogWarning("More than one instance found");
				Destroy(gameObject);
				return;
			}
			instance = this;
		}

		public bool AddItem(CoinsItem item)
		{
			if (items.Count > inventoryCapacity) {
				Debug.Log("Inventory is full");
				return false;
			}
			items.Add(item);
			OnInventoryChanged?.Invoke();
			Debug.Log($"Added item: {item.name}");
			return true;
		}

		public bool RemoveItem(CoinsItem item)
		{
			bool removed = items.Remove(item);
			if (removed) {
				OnInventoryChanged?.Invoke();
				Debug.Log($"Removed item: {item.name}");
			} else {
				Debug.Log($"Could not find item to remove: {item.name}");
			}
			return removed;
		}

		public bool UseItem(CoinsItem item) {
			if (items.Contains(item))
			{
				item.Use();

				RemoveItem(item);
			}
			else
			{
				Debug.Log($"Cannot use ${item.name}: not in inventory");
			}
		}

		public List<CoinsList> GetItems() {
			return new List<CoinsList>(items);
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.I)) {
				Debug.Log("Current Inventory:");
				foreach (var coin in items) {
					Debug.Log("- " + items.name);
				}
			}
		}

	  //public GameObject player;
	  //public GameObject inventory;
	  //public GameObject inventoryItem;
	  //public GameObject inventoryItemItem;
		
	}
}
