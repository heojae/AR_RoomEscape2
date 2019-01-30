using UnityEngine;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;	// The entire UI

	Inventory2 inventory;	// Our current inventory

	InventorySlot2[] slots;	// List of all the slots

	void Start () {
		inventory = Inventory2.instance;
        //inventory.onItemChangedCallback += UpdateUI;	// Subscribe to the onItemChanged callback
        
        // Populate our slots array
        slots = itemsParent.GetComponentsInChildren<InventorySlot2>();
        //UpdateUI();
    }
	
	void Update () {
        // Check to see if we should open/close the inventory

        /*
        if (Input.GetButtonDown("Inventory"))
		{
			inventoryUI.SetActive(!inventoryUI.activeSelf);
		}
        */

        UpdateUI();

    }

	// Update the inventory UI by:
	//		- Adding items
	//		- Clearing empty slots
	// This is called using a delegate on the Inventory.
	void UpdateUI ()
	{
        Debug.Log(slots.Length);
		// Loop through all the slots
		for (int i = 0; i < slots.Length; i++)
		{
			if (i < inventory.items.Count)	// If there is an item to add
			{
				slots[i].AddItem(inventory.items[i]);	// Add it
			} else
			{
				// Otherwise clear the slot
				slots[i].ClearSlot();
			}
		}
	}
}
