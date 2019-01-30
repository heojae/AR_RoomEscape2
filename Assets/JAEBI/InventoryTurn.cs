using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTurn : MonoBehaviour
{
    public GameObject defaultGame;

    [SerializeField]
    private GameObject scriptGame;


    


    [SerializeField] private GameObject turnButton;
    private bool check=false;
    private GameObject checkfinal;
    private GameObject checkfinal2;

    public Text myText;

    public GameObject other;

    // Start is called before the first frame update
    void Start()
    {

        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTurnButton()
    {
        scriptGame.SetActive(check);

        check = !check;
        turnButton.SetActive(check);

        //checkfinal = GetComponent<InventorySlot2>().icon_for_use.sprite;


        checkfinal = InventorySlot2.finalObject;


        

        

    }



}
