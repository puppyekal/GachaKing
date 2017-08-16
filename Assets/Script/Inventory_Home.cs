using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Home : MonoBehaviour {

    public GameObject Example;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;

    // Use this for initialization
    void Start () {
        Example.SetActive(false);
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void Example_Button()
    {
        Example.SetActive(true);
    }
    public void Item1_Button()
    {
        Item1.SetActive(true);
    }
    public void Item2_Button()
    {
        Item2.SetActive(true);
    }
    public void Item3_Button()
    {
        Item3.SetActive(true);
    }
    public void Item4_Button()
    {
        Item4.SetActive(true);
    }
    public void Item5_Button()
    {
        Item5.SetActive(true);
    }
    public void Item6_Button()
    {
        Item6.SetActive(true);
    }
    public void Item7_Button()
    {
        Item7.SetActive(true);
    }
    public void Item8_Button()
    {
        Item8.SetActive(true);
    }
}
