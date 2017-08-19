using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Home : MonoBehaviour {

    public Button Store_item1;
    public Button Store_item2;
    public Button Store_item3;
    public Button Store_item4;
    public Button Store_item5;
    public Button Store_item6;
    public Button Store_item7;

    public GameObject Inventory_Item1;
    public GameObject Inventory_Item2;
    public GameObject Inventory_Item3;
    public GameObject Inventory_Item4;
    public GameObject Inventory_Item5;
    public GameObject Inventory_Item6;
    public GameObject Inventory_Item7;
    
    public Text Money_Text;

    // Use this for initialization
    void Start () {
        Store_item1.interactable = false;
        Store_item2.interactable = false;
        Store_item3.interactable = false;
        Store_item4.interactable = false;
        Store_item5.interactable = false;
        Store_item6.interactable = false;
        Store_item7.interactable = false;

        Inventory_Item1.SetActive(false);
        Inventory_Item2.SetActive(false);
        Inventory_Item3.SetActive(false);
        Inventory_Item4.SetActive(false);
        Inventory_Item5.SetActive(false);
        Inventory_Item6.SetActive(false);
        Inventory_Item7.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

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

        Money_Text.GetComponent<Text>().text = "" + Text_Event.Money;
    }
    public void Item1_Button()
    {
        Inventory_Item1.SetActive(true);
        Text_Event.Money -= 33333;
        Store_item1.interactable = false;
    }
    public void Item2_Button()
    {
        Inventory_Item2.SetActive(true);
        Text_Event.Money -= 33333;
        Store_item2.interactable = false;
    }
    public void Item3_Button()
    {
        Inventory_Item3.SetActive(true);
        Text_Event.Money -= 33333;
        Store_item3.interactable = false;
    }
    public void Item4_Button()
    {
        Inventory_Item4.SetActive(true);
        Text_Event.Money -= 150000;
        Store_item4.interactable = false;
    }
    public void Item5_Button()
    {
        Inventory_Item5.SetActive(true);
        Text_Event.Money -= 4200;
        Store_item5.interactable = false;
    }
    public void Item6_Button()
    {
        Inventory_Item6.SetActive(true);
        Text_Event.Money -= 100000;
        Store_item6.interactable = false;
    }
    public void Item7_Button()
    {
        Inventory_Item7.SetActive(true);
        Text_Event.Money -= 500000;
        Store_item7.interactable = false;
    }
}
