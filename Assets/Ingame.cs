using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour {

    
    public GameObject Area_1;
    public GameObject Area_2;
    public GameObject Area_3;
    public GameObject Area_4;
    public GameObject Area_5;
  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

        }
    }
    
}
