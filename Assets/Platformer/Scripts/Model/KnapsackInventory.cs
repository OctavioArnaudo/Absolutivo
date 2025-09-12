using UnityEngine;
using System.Collections.Generic;
using System;

namespace Platformer.Gameplay
{
	public class KnapsackInventory : MonoBehaviour
	{
		public static KnapsackInventory instance;
		public event Action<KnapsackInventory> OnInventoryChanged;

		[Header("Inventory Settings")]
		[SerializeField] private int inventoryCapacity = 3;

		public List<InventoryItem> items = new List<InventoryItem> ();

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

		public bool AddItem(InventoryItem item)
		{
			if (items.Count > inventoryCapacity) {
				Debug.Log("Inventory is full");
				return false;
			}
			items.Add(item);
			OnInventoryChanged?.Invoke(instance);
			Debug.Log($"Added item: {item.name}");
			return true;
		}

		public bool RemoveItem(InventoryItem item)
		{
			bool removed = items.Remove(item);
			if (removed) {
				OnInventoryChanged?.Invoke(instance);
				Debug.Log($"Removed item: {item.name}");
			} else {
				Debug.Log($"Could not find item to remove: {item.name}");
			}
			return removed;
		}

		public bool UseItem(InventoryItem item) {
			if (items.Contains(item))
			{
				item.Use();

				RemoveItem(item);
			}
			else
			{
				Debug.Log($"Cannot use ${item.name}: not in inventory");
			}
			return false;
		}

		public List<InventoryItem> GetItems() {
			return new List<InventoryItem>(items);
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.I)) {
				Debug.Log("Current Inventory:");
				foreach (var coin in items) {
					Debug.Log("- " + coin.name);
				}
			}
		}

	  //public GameObject player;
	  //public GameObject inventory;
	  //public GameObject inventoryItem;
	  //public GameObject inventoryItemItem;
		
	}
}
