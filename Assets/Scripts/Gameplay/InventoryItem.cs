using System.Diagnostics;
using System.Diagnostics.Contracts;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class InventoryItem : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    [TextArea(3, 10)]
    public string description = "A generic item";

    public virtual void Use()
    {
        Debug.Log("Using " + item);
    }
}