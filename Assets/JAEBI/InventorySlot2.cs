using UnityEngine;
using UnityEngine.UI;

/* Sits on all InventorySlots. */

public class InventorySlot2 : MonoBehaviour
{
    public Text myText;

    public Image icon;          // Reference to the Icon image
    public Image icon_for_use;          // Reference to the Icon image
    public Button removeButton; // Reference to the remove button


    public Sprite icon1 = null;
    public Sprite icon2 = null;
    public Sprite icon3 = null;
    public Sprite icon4 = null;

    public Sprite brain_jar1 = null;
    public Sprite brain_jar2 = null;
    public Sprite glass_jar = null;
    public Sprite key_silver = null;
    public Sprite Oilcan1 = null;
    public Sprite ColaCan = null;

    public GameObject checkGame;

    public GameObject defaultGame;

    public static GameObject finalObject;

    Item item;  // Current item in the slot


    void Start() {
        finalObject = defaultGame;
    }

    

    // Add item to the slot
    public void AddItem(GameObject gameObject)
    {
        /*
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
        */
        //myText.GetComponent<Text>().text = "slot2-addList";
        //Debug.Log("slot2-addList");
        //Debug.Log(gameObject.name + "fdfadfdas");
        if (gameObject.name == "TestItem1")
        {

            //Debug.Log("slot2-addList-TestItem1");
            checkGame = gameObject;

            icon.sprite = icon1;
            icon.enabled = true;
            removeButton.interactable = true;
        }
        if (gameObject.name == "TestItem2")
        {
            checkGame = gameObject;
            icon.sprite = icon2;
            icon.enabled = true;
            removeButton.interactable = true;
        }
        if (gameObject.name == "TestItem3")
        {
            checkGame = gameObject;
            icon.sprite = icon3;
            icon.enabled = true;
            removeButton.interactable = true;
        }
        if (gameObject.name == "brain_jar1")
        {
            checkGame = gameObject;
            icon.sprite = brain_jar1;
            icon.enabled = true;
            removeButton.interactable = true;
        }

        if (gameObject.name == "brain_jar2")
        {
            checkGame = gameObject;
            icon.sprite = brain_jar2;
            icon.enabled = true;
            removeButton.interactable = true;
        }

        if (gameObject.name == "glass_jar")
        {
            checkGame = gameObject;
            icon.sprite = glass_jar;
            icon.enabled = true;
            removeButton.interactable = true;
        }

        if (gameObject.name == "key_silver")
        {
            checkGame = gameObject;
            icon.sprite = key_silver;
            icon.enabled = true;
            removeButton.interactable = true;
        }
        if (gameObject.name == "Oilcan1")
        {
            checkGame = gameObject;
            icon.sprite = Oilcan1;
            icon.enabled = true;
            removeButton.interactable = true;
        }
        if (gameObject.name == "ColaCan")
        {
            checkGame = gameObject;
            icon.sprite = ColaCan;
            icon.enabled = true;
            removeButton.interactable = true;
        }




    }

    // Clear the slot
    public void ClearSlot()
    {
        //Debug.Log("slot2-ClearSlot");
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    // Called when the remove button is pressed
    public void OnRemoveButton()
    {
        Inventory2.instance.Remove(checkGame);
    }

    // Called when the item is pressed
    public void UseItem()
    {
        if (checkGame != null)
        {
            if (checkGame.name == "TestItem1")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = icon1;
                icon_for_use.enabled = true;
                removeButton.interactable = false;
            }
            else if (checkGame.name == "TestItem2")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = icon2;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }
            else if (checkGame.name == "TestItem3")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = icon3;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }
            else if (checkGame.name == "brain_jar1")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = brain_jar1;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }
            else if (checkGame.name == "brain_jar2")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = brain_jar2;
                icon_for_use.enabled = true;
                removeButton.interactable = false;
            }
            else if (checkGame.name == "glass_jar")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = glass_jar;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }
            else if (checkGame.name == "key_silver")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = key_silver;
                icon_for_use.enabled = true;
                removeButton.interactable = false;
            }
            else if (checkGame.name == "Oilcan1")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = Oilcan1;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }
            else if (checkGame.name == "ColaCan")
            {
                finalObject = checkGame;
                //myText.GetComponent<Text>().text = "using" + finalObject.name;

                icon_for_use.sprite = ColaCan;
                icon_for_use.enabled = true;
                removeButton.interactable = false;

            }



            Debug.Log("using" + checkGame.name);
        }
    }

    public GameObject Returnfinal() {

        if (finalObject != null)
        {
            return finalObject;
        }
        else {
            return defaultGame;
        }
    }


}
