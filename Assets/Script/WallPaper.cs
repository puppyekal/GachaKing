using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallPaper : MonoBehaviour {

    public Button Store_item1;
    public Button Store_item2;
    public Button Store_item3;

    public GameObject Inventory_Item1;
    public GameObject Inventory_Item2;
    public GameObject Inventory_Item3;

    public Text Money_Text;

    // Use this for initialization
    void Start () {
        Store_item1.interactable = false;
        Store_item2.interactable = false;
        Store_item3.interactable = false;


        Inventory_Item1.SetActive(false);
        Inventory_Item2.SetActive(false);
        Inventory_Item3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if(Achivement.Achivement_Time_EX_cnt==1)
        {
            Store_item1.interactable = true;
            Store_item2.interactable = true;
            Store_item3.interactable = true;

            Achivement.Achivement_Time_EX_cnt = 2;
        }

        Money_Text.GetComponent<Text>().text = "" + Text_Event.Money;
    }

    public void Item1_Button()
    {
        if (Text_Event.Money - 10000 < 0)
        {

        }
        else
        {
            Inventory_Item1.SetActive(true);
            Text_Event.Money -= 10000;
            Store_item1.interactable = false;
        }
    }
    public void Item2_Button()
    {
        if (Text_Event.Money - 50000 < 0)
        {

        }
        else
        {
            Inventory_Item2.SetActive(true);
            Text_Event.Money -= 50000;
            Store_item2.interactable = false;
        }
    }
    public void Item3_Button()
    {
        if (Text_Event.Money - 5000000 < 0)
        {

        }
        else
        {
            Inventory_Item3.SetActive(true);
            Text_Event.Money -= 5000000;
            Store_item3.interactable = false;
        }
    }
}
