using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore;

public class Script1 : MonoBehaviour
{
    public GameObject door_01;
    public GameObject door_02;
    public Camera FirstPersonCamera;
    public GameObject water1;
    public GameObject cabinet_door2_left;
    public GameObject cabinet_door2_right;
    public GameObject cabinet_door3_left;
    public GameObject cabinet_door3_right;
    public GameObject cabinet_door4_left;
    public GameObject cabinet_door4_right;
    public GameObject corpse_drawer_open3;
    public GameObject corpse_drawer_open4;
    public GameObject corpse_drawer_open5;
    public GameObject corpse_drawer_open6;
    public GameObject corpse_drawer_open7;
    public GameObject corpse_drawer_open8;
    public GameObject corpse_drawer_open9;
    public GameObject corpse_drawer_open10;
    public GameObject corpse_drawer_open11;
    public GameObject corpse_drawer_close3;
    public GameObject corpse_drawer_close4;
    public GameObject corpse_drawer_close5;
    public GameObject corpse_drawer_close6;
    public GameObject corpse_drawer_close7;
    public GameObject corpse_drawer_close8;
    public GameObject corpse_drawer_close9;
    public GameObject corpse_drawer_close10;
    public GameObject corpse_drawer_close11;
    public GameObject lockerClose;
    public GameObject lockerOpen;
    public GameObject blood1;
    public GameObject blood3;
    public GameObject key_silver;

    //도연이 추가
    public GameObject open_door_01;
    public GameObject open_door_02;

    //도연이 추가, 여기서부터는 지우지 마. 아이템별로 안내판 달려고 만든거니까.
    public GameObject BlackBoardHint;





    //jaebi
    [SerializeField]
    private GameObject myText;
    private int pad = 1;
    private int time1 = 0;
    private int time2 = 0;



    private int pad2 = 1;
    private int time3 = 0;
    private int time4 = 0;

    private int c=0;





    private TouchScreenKeyboard keyboard;
    private string textFieldString = "";
    public string stringToEdit = "Hello World";
    private bool check = true;

    private bool checkKey=false;
    private bool checkCola=false;

    [SerializeField]
    private GameObject FindKey;
    private Vector3 checkPosition;
    private GameObject recheckGame;
    public InputField password1;
    public InputField password2;


    [SerializeField] private GameObject brain_1;




    private int a = 0;

    private int b = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //jaebi
        if (time1 != 0)
        {
            time1 = time1 + 1;
        }
        time2 = time2 + 1;

        if (time3 != 0)
        {
            time3 = time3 + 1;
        }
        time4 = time4 + 1;

        if (password1.text == "2018")
        {
            pad = pad + 1;
            password1.gameObject.SetActive(false);

            cabinet_door4_left.SetActive(false);
            cabinet_door4_right.SetActive(true);
            //myText.GetComponent<Text>().text = "successs";

            if (a == 0) {
                myText.GetComponent<Text>().text = "콜라를 얻었다. 핏자국을 지우는 데에는 김이 빠진 콜라가 좋다는 팁이 떠올랐다.";
                a = a + 1;
            }
            a = a + 1;
            checkCola = true;
        }

        if (password2.text == "1275")
        {
            myText.GetComponent<Text>().text = "끝냈다 난 자유다 안녕 에러들아";
            pad2 = pad2 + 1;
            password2.gameObject.SetActive(false);

            door_01.SetActive(false);
            door_02.SetActive(false);
            open_door_01.SetActive(true);
            open_door_02.SetActive(true);

            if (b == 0) {
                //myText.GetComponent<Text>().text = "끝냈다 난 자유다 잘있어라 에러들아";
                b = b + 1;
            }
            b = b + 1;

            

            //myText.GetComponent<Text>().text = "successs";         


        }

        RaycastHit hit;
        Ray ray = FirstPersonCamera.ScreenPointToRay(Input.GetTouch(0).position);
        if (Physics.Raycast(ray, out hit))
        {
            //myText.GetComponent<Text>().text = hit.transform.name;
            //DY: 우선 주석처리해둠

            if (hit.transform.name == "cabinet_door2_left")
            {
                cabinet_door2_left.SetActive(false);
                cabinet_door2_right.SetActive(true);
            }
            else if (hit.transform.name == "cabinet_door2_right")
            {
                cabinet_door2_left.SetActive(true);
                cabinet_door2_right.SetActive(false);
            }
            else if (hit.transform.name == "cabinet_door4_right")
            {
                cabinet_door4_left.SetActive(true);
                cabinet_door4_right.SetActive(false);
            }
            else if (hit.transform.name == "cabinet_door4_left")
            {
                myText.GetComponent<Text>().text = "키패드로 잠겨있다. 네 자리 수를 입력해야 열리는 것 같다.";
                if (pad % 2 == 1 && time2 > 60)
                {
                    password1.gameObject.SetActive(true);
                    time1 = 1;
                    pad = pad + 1;
                }
                else
                {
                    if (time1 > 60)
                    {
                        password1.gameObject.SetActive(false);
                        pad = pad + 1;
                        time1 = 0;
                        time2 = 0;
                    }
                }
            }

            //DY: 기타 사물들 클릭했을 때 뜨는 문구 업데이트 중
            else if (hit.transform.name == "BlackBoardHint") //칠판
            {
                myText.GetComponent<Text>().text = "칠판에 숫자들이 적혀 있다. 캐비닛에 달린 키패드의 힌트같은데.. 어떤 규칙일까.";
            }

            else if (hit.transform.name == "glass_jar") //유리병
            {
                myText.GetComponent<Text>().text = "빈 유리병을 얻었다.";
            }

            else if (hit.transform.name == "corpse_drawer_close4") //우선 4번만
            {
                myText.GetComponent<Text>().text = "시체 안치용 냉장고다.";
            }

            else if (hit.transform.name == "Oilcan1") //염산
            {
                myText.GetComponent<Text>().text = "염산이다. 피부를 태울 수 있으니 조심하자.";
            }

            else if (hit.transform.name == "Picture") //사진
            {
                myText.GetComponent<Text>().text = "가슴이 따뜻해지는 사진이다.";
            }

            else if (hit.transform.name == "paper1") //책상 위 종이
            {
                myText.GetComponent<Text>().text = "낡은 종이다. 여기에 나보다도 먼저 와 있던 사람이 있었던 걸까.. 불길한 내용이 적혀 있다.";
            }

            else if (hit.transform.name == "Zombie") //좀비
            {
                myText.GetComponent<Text>().text = "잔뜩 경직된 시체다. 당장이라도 일어나서 날 쫓아올 것 같지만, 렉이 심해 그런 일은 일어나지 않았다.";
            }

            else if (hit.transform.name == "Hint") //탈출용 힌트
            {
                myText.GetComponent<Text>().text = "brain + 2eyes? 키패드의 힌트인가?";
            }

            else if (hit.transform.name == "brain_jar1") //brain jar 얻음
            {
                myText.GetComponent<Text>().text = "뇌가 든 병을 얻었다.";
            }

            else if (hit.transform.name == "brain_jar2") //eye jar 얻음
            {
                myText.GetComponent<Text>().text = "안구 두 개가 든 병을 얻었다.";
            }

            else if (hit.transform.name == "organ_scale") //스케일 클릭
            {
                myText.GetComponent<Text>().text = "사람의 장기를 측정하는 저울이다.";
            }

            //DY: 여기까지


            if (hit.transform.name == "organ_scale")
            {
                if (InventorySlot2.finalObject.name == "glass_jar")
                {
                    myText.GetComponent<Text>().text = "빈 유리병의 무게는 1000g이다.";
                }
                if (InventorySlot2.finalObject.name == "brain_jar2")
                {
                    myText.GetComponent<Text>().text = "눈이 든 병의 무게는 1075g이다.";
                }
                if (InventorySlot2.finalObject.name == "brain_jar1")
                {
                    myText.GetComponent<Text>().text = "뇌가 든 병의 무게는 2200g이다.";
                }
            }
            else if (hit.transform.name == "tapPlane")
            {
                water1.SetActive(true);
            }
            /*else if (hit.transform.name == "door_01" || hit.transform.name == "door_02")
            {
                door_01.transform.rotation = Quaternion.Euler(0, -90, 0);
                door_02.transform.rotation = Quaternion.Euler(0, -90, 0);
            }*/
            else if (hit.transform.name == "corpse_drawer_close3")
            {
                corpse_drawer_close3.SetActive(false);
                corpse_drawer_open3.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close4")
            {
                corpse_drawer_close4.SetActive(false);
                corpse_drawer_open4.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close5")
            {
                corpse_drawer_close5.SetActive(false);
                corpse_drawer_open5.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close6")
            {
                corpse_drawer_close6.SetActive(false);
                corpse_drawer_open6.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close7")
            {

                if (!blood1.activeSelf)
                {                    
                    corpse_drawer_close7.SetActive(false);
                    corpse_drawer_open7.SetActive(true);
                }
                else if (InventorySlot2.finalObject.name == "ColaCan")
                {
                    blood1.SetActive(false);
                    blood3.SetActive(false);
                    myText.GetComponent<Text>().text = "피를 지웠다.";
                }
                else
                {
                    myText.GetComponent<Text>().text = "피가 경첩에 말라붙어 있어 열리지 않는다. 피를 지울만한 게 필요하다.";
                }

            }
            else if (hit.transform.name == "corpse_drawer_close8")
            {
                corpse_drawer_close8.SetActive(false);
                corpse_drawer_open8.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close9")
            {
                corpse_drawer_close9.SetActive(false);
                corpse_drawer_open9.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close10")
            {
                corpse_drawer_close10.SetActive(false);
                corpse_drawer_open10.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_close11")
            {
                corpse_drawer_close11.SetActive(false);
                corpse_drawer_open11.SetActive(true);
            }
            else if (hit.transform.name == "corpse_drawer_open3")
            {
                corpse_drawer_close3.SetActive(true);
                corpse_drawer_open3.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open4")
            {
                corpse_drawer_close4.SetActive(true);
                corpse_drawer_open4.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open5")
            {
                corpse_drawer_close5.SetActive(true);
                corpse_drawer_open5.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open6")
            {
                corpse_drawer_close6.SetActive(true);
                corpse_drawer_open6.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open7")
            {
                corpse_drawer_close7.SetActive(true);
                corpse_drawer_open7.SetActive(false);


                brain_1.SetActive(true);


            }
            else if (hit.transform.name == "corpse_drawer_open8")
            {
                corpse_drawer_close8.SetActive(true);
                corpse_drawer_open8.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open9")
            {
                corpse_drawer_close9.SetActive(true);
                corpse_drawer_open9.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open10")
            {
                corpse_drawer_close10.SetActive(true);
                corpse_drawer_open10.SetActive(false);
            }
            else if (hit.transform.name == "corpse_drawer_open11")
            {
                corpse_drawer_close11.SetActive(true);
                corpse_drawer_open11.SetActive(false);
            }

            else if (hit.transform.name == "lockerClose")
            {
                if (InventorySlot2.finalObject.name == "key_silver") // 열쇠가 있는 경우
                {
                    myText.GetComponent<Text>().text = "열쇠로 문을 열었다.";
                    lockerClose.SetActive(false);
                    lockerOpen.SetActive(true);
                }
                else
                {
                    myText.GetComponent<Text>().text = "문이 잠겨 있어 열리지 않는다. 열쇠로 문을 열 수 있다.";
                }
            }

            /*else if (hit.transform.name == "lockerClose" && InventorySlot2.finalObject.name == "key_silver")
            {
                lockerClose.SetActive(false);
                lockerOpen.SetActive(true);
            }*/

            else if (hit.transform.name == "lockerOpen") //열려있는 문 닫게 하는 코드
            {
                lockerClose.SetActive(true);
                lockerOpen.SetActive(false);
            }

            else if (hit.transform.name == "water2") //고인물
            {

                myText.GetComponent<Text>().text = "안에 반짝이는 열쇠가 보인다. 꺼내려고 손을 뻗은 순간, 수면 위로 머리카락이 떨어지며 순식간에 녹아버렸다. 아차, 여기에 담긴 물은 강한 염기성을 띤 액체인 듯 하다.";
                if (InventorySlot2.finalObject.name == "Oilcan1")
                {
                    myText.GetComponent<Text>().text = "아까 얻은 염산을 뿌려 중화시켰다. 안에 있는 열쇠를 얻었다.";
                    key_silver.GetComponent<Collider>().enabled = true;
                    checkPosition = hit.transform.position;
                    checkKey = true;
                    // FindKey.SetActive(true);
                }
            }


            /*
            else if ((hit.transform.name == "water2" || hit.transform.name == "metal_sink") && InventorySlot2.finalObject.name == "Oilcan1")
            {
                key = true;
            }*/
            //jaebi
            // add to inventory when clicked
            else if (hit.transform.name == "TestItem1" || hit.transform.name == "TestItem2" || hit.transform.name == "TestItem3")
            {
                
                Inventory2.instance.Add(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);
            }
            else if (hit.transform.name == "brain_jar1" )
            {
             
                
                Inventory2.instance.Add(hit.collider.gameObject);
                
                hit.collider.gameObject.SetActive(false);
            }
            else if ( hit.transform.name == "brain_jar2" || hit.transform.name == "glass_jar")
            {

                Inventory2.instance.Add(hit.collider.gameObject);

                hit.collider.gameObject.SetActive(false);
            }

            if ((hit.transform.name == "key_silver" || hit.transform.name == "water2") && checkKey)
            {
                if (c == 0) {
                    Inventory2.instance.Add(key_silver);
                    //Destroy(hit.collider.gameObject);
                    key_silver.SetActive(false);
                    checkKey = false;
                    c = c + 1;
                }
                c = c + 1;
                
            }
            else if (hit.transform.name == "Oilcan1" || hit.transform.name == "ColaCan")
            {
                
                Inventory2.instance.Add(hit.collider.gameObject);
                //Destroy(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);
            }



            else if (hit.transform.name == "ColaCan"  && checkCola)
            {
                Debug.Log(hit.transform.name);
                Inventory2.instance.Add(hit.collider.gameObject);
                //Destroy(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);
            }


            //키패드부분

            else if (hit.transform.name == "keypad_escape" || hit.transform.name == "keypad")
            {

                myText.GetComponent<Text>().text = "키패드로 잠겨있다. 탈출을 위해서는 이 문을 나가야 하는데, 네 자리 수를 입력해야 열리는 것 같다.";
                if (pad2 % 2 == 1 && time4 > 60)
                {
                    password2.gameObject.SetActive(true);
                    time3 = 1;
                    pad2 = pad2 + 1;
                }
                else
                {
                    if (time3 > 60)
                    {
                        password2.gameObject.SetActive(false);
                        pad2 = pad2 + 1;
                        time3 = 0;
                        time4 = 0;
                    }
                }

                                                                                 
            }
            else if (hit.transform.name == "cola") {
                Inventory2.instance.Add(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);
            }
            











        }
        


    }
}
