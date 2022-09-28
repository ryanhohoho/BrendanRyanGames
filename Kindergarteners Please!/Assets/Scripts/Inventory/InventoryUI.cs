using UnityEngine;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;	// The entire UI

	Inventory inventory;	// Inventory initiated

	InventorySlot[] slots;	// slots list

	void Start() {
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;	// This was copypasted but I think it tells the Inventory class to put an icon in the frame

		// Fill up the slots list
		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}
	
	void Update() {
		// Check to see if we should open/close the inventory
		if (Input.GetButtonDown("Inventory"))
			inventoryUI.SetActive(!inventoryUI.activeSelf);
	}

	// Update the inventory UI by:
	//		- Adding items
	//		- Clearing empty slots
	// This is called with the delegate
	void UpdateUI()
	{
		// Loop through all the slots
		for (int i = 0; i < slots.Length; i++)
		{
			if (i < inventory.items.Count)	// If there is an item to add
			{
				slots[i].AddItem(inventory.items[i]);	// Add it
			} 
			else
			{
				// Otherwise clear the slot
				slots[i].ClearSlot();
			}
		}
	}
}
