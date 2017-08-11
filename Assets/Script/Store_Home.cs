using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_Home : MonoBehaviour
{
    public GameObject Button_EX;
    public Button example;

    // Use this for initialization
    void Start()
    {
        example.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Achivement.Achivement_EX_cnt == 1)
        {
            example.interactable = true;
        }

    }
}
