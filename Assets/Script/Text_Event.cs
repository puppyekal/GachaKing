using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Event : MonoBehaviour {
    public Text Money_Text;
    public Text Gacha_Num_Text;
    public Text Gacha_Level_Text;

    int Money = 10000000;
    int Gacha_Num = 0;
    int Gacha_Level = 1;
    // Use this for initialization
    void Start () {
        Money_Text.GetComponent<Text>().text = "" + Money;
        Gacha_Num_Text.GetComponent<Text>().text = Gacha_Num + " / 10";
        Gacha_Level_Text.GetComponent<Text>().text = Gacha_Level + " / 9";
    }
	
	// Update is called once per frame
    void Update(){

    }
}
