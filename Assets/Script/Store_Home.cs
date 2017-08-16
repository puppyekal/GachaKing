using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_Home : MonoBehaviour
{
    //   public GameObject Button_EX;
    public Button example;
    public Button item1;
    public Button item2;
    public Button item3;
    public Button item4;
    public Button item5;
    public Button item6;
    public Button item7;
    public Button item8;

    // Use this for initialization
    void Start()
    {
        example.interactable = false;
        item1.interactable = false;
        item2.interactable = false;
        item3.interactable = false;
        item4.interactable = false;
        item5.interactable = false;
        item6.interactable = false;
        item7.interactable = false;
        item8.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Achivement.Achivement_EX_cnt == 1)
        {
            example.interactable = true;
            item1.interactable = true;
            item2.interactable = true;
            item3.interactable = true;
            item4.interactable = true;
            item5.interactable = true;
            item6.interactable = true;
            item7.interactable = true;
            item8.interactable = true;
        }
    }
}
