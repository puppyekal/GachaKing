using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_Home : MonoBehaviour
{
    //   public GameObject Button_EX;
    public Button Store_item1;
    public Button Store_item2;
    public Button Store_item3;
    public Button Store_item4;
    public Button Store_item5;
    public Button Store_item6;
    public Button Store_item7;

    // Use this for initialization
    void Start()
    {
        Store_item1.interactable = false;
        Store_item2.interactable = false;
        Store_item3.interactable = false;
        Store_item4.interactable = false;
        Store_item5.interactable = false;
        Store_item6.interactable = false;
        Store_item7.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Achivement.Achivement_EX_cnt == 1)
        {
            Store_item1.interactable = true;
            Store_item2.interactable = true;
            Store_item3.interactable = true;
            Store_item4.interactable = true;
            Store_item5.interactable = true;
            Store_item6.interactable = true;
            Store_item7.interactable = true;
        }
    }
}
