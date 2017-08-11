using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Home : MonoBehaviour {

    public GameObject Example;

	// Use this for initialization
	void Start () {
        Example.SetActive(false);
        Debug.Log(11);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Example_Button()
    {
        Example.SetActive(true);
    }
}
