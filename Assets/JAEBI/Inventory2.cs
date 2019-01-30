using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory2 : MonoBehaviour
{
    public Text myText;

    #region Singleton

    public static Inventory2 instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }

    #endregion
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    // Callback which is triggered when
    // an item gets added/removed.


    public int space = 20;  // Amount of slots in inventory

    // Current list of items in inventory
    public List<GameObject> items = new List<GameObject>();

    // Add a new item. If there is enough room we
    // return true. Else we return false.
    public bool Add(GameObject gameObject)
    {

        
       // myText.GetComponent<Text>().text = "inven - add";
        items.Add(gameObject);  // Add item to list
        //if (onItemChangedCallback != null)
        //    onItemChangedCallback.Invoke();



        return true;
    }

    // Remove an item
    public void Remove(GameObject gameObject)
    {
        items.Remove(gameObject);       // Remove item from list

        // Trigger callback
        
    }

}
