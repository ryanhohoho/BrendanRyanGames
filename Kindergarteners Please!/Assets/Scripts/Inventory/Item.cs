using UnityEngine;

/* The base item class. All items derive from this! Brendan if u code items sorry for the naming convention */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

	new public string name = "New Item";    // Name of the item
	public Sprite icon = null;              // Item icon

	// Called when the item is pressed in the inventory but nothing yet
	public virtual void Use()
	{
		//Just keeping this so I remember
	}

	public void RemoveFromInventory()
	{
		//Removes the item from the inventory
		Inventory.instance.Remove(this);
	}

}