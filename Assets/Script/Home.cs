using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour {

    public Button Store_item1;
    public Button Store_item2;
    public Button Store_item3;
    public Button Store_item4;
    public Button Store_item5;
    public Button Store_item6;
    public Button Store_item7;
    public Button Store_item8;
    public Button Store_item9;
    public Button Store_item10;
    public Button Store_item11;
    public Button Store_item12;
    public Button Store_item13;
    public Button Store_item14;
    public Button Store_item15;
    public Button Store_item16;

    public GameObject Inventory_Item1;
    public GameObject Inventory_Item2;
    public GameObject Inventory_Item3;

    public Text Money_Text;

    static public int Item_Cnt = 0;

    // Use this for initialization
    void Start() {
        /*
        //업적 해금 전까지 버튼 비활성화
        Store_item1.interactable = false;
        Store_item2.interactable = false;
        Store_item3.interactable = false;
        Store_item4.interactable = false;
        Store_item5.interactable = false;
        Store_item6.interactable = false;
        Store_item7.interactable = false;

    
        //상점에서 구매 전까지 버튼 미생성 
        Inventory_Item1.SetActive(false);
        Inventory_Item2.SetActive(false);
        Inventory_Item3.SetActive(false);
        Inventory_Item4.SetActive(false);
        Inventory_Item5.SetActive(false);
        Inventory_Item6.SetActive(false);
        Inventory_Item7.SetActive(false);
        */
    }

    // Update is called once per frame
    void Update() {
        //업적 해금시 버튼 활성화
        /*
        if (Achivement.Achivement_EX_cnt == 1)
        {
            Store_item1.interactable = true;
            Store_item2.interactable = true;
            Store_item3.interactable = true;
            Store_item4.interactable = true;
            Store_item5.interactable = true;
            Store_item6.interactable = true;
            Store_item7.interactable = true;

            Achivement.Achivement_EX_cnt = 2;
        }
        */
        Money_Text.GetComponent<Text>().text = "" + Text_Event.Money;
    }
    public void PressKey(int nKey)
    {
        switch (nKey)
        {
            case 1:
                Debug.Log(1);
                break;
            case 2:
                Debug.Log(2);
                break;
            case 3:
                Debug.Log(3);
                break;
            case 4:
                Debug.Log(4);
                break;
            case 5:
                Debug.Log(5);
                break;
            case 6:
                Debug.Log(6);
                break;
            case 7:
                Debug.Log(7);
                break;
            case 8:
                Debug.Log(8);
                break;
            case 9:
                Debug.Log(9);
                break;
            case 10:
                Debug.Log(10);
                break;
            case 11:
                Debug.Log(11);
                break;
            case 12:
                Debug.Log(12);
                break;
            case 13:
                Debug.Log(13);
                break;
            case 14:
                Debug.Log(14);
                break;
            case 15:
                Debug.Log(15);
                break;
            case 16:
                Debug.Log(16);
                break;
        }
    }
    /*
    public void Item1_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item1.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item1.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item2_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item2.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item2.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item3_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item3.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item3.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item4_Button()
    {
        if (Text_Event.Money - 150000 < 0)
        {

        }
        else
        {
            Inventory_Item4.SetActive(true);
            Text_Event.Money -= 150000;
            Store_item4.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item5_Button()
    {
        if (Text_Event.Money - 4200 < 0)
        {

        }
        else
        {
            Inventory_Item5.SetActive(true);
            Text_Event.Money -= 4200;
            Store_item5.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item6_Button()
    {
        if (Text_Event.Money - 100000 < 0)
        {

        }
        else
        {
            Inventory_Item6.SetActive(true);
            Text_Event.Money -= 100000;
            Store_item6.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item7_Button()
    {
        if (Text_Event.Money - 500000 < 0)
        {

        }
        else
        {
            Inventory_Item7.SetActive(true);
            Text_Event.Money -= 500000;
            Store_item7.interactable = false;
            Item_Cnt++;
        }
    }
    */

}
