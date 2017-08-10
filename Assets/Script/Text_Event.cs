using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Event : MonoBehaviour {
    public Text Money_Text;
    public Text Gacha_Num_Text;
    public Text Gacha_Level_Text;

    public Text Gacha_Price_Text;

    static public int Money = 10000000;
    public static int Gacha_Level = 1;
    int Gacha_Price_Check = 0;//레벨에따른 판매가 변경 확인에 대한 체크
    int[] Gacha_Price = new int[] { 20000, 80000, 32000, 1280000, 5120000, 20480000, 81920000, 327680000, 1310720000 };
  
    // Use this for initialization
    void Start () {
        switch (Gacha_Price_Check)
        {
            case 0:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 1:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 2:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 3:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 4:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 5:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 6:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 7:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 8:
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
        }
    }
	
	// Update is called once per frame
    void Update(){
        Money_Text.GetComponent<Text>().text = "" + Money;
        Gacha_Num_Text.GetComponent<Text>().text = Ingame.Gacha_Tong_Num + " / 10";
        Gacha_Level_Text.GetComponent<Text>().text = Gacha_Level + " / 9";
    }

    public void Store_Gacha_Buy()//가챠 구매시 돈 감소
    {
        Money = Money - Gacha_Price[Gacha_Price_Check];
    }

    public void Store_Gacha_Level_Buy()
    {
        Gacha_Level++;
        Gacha_Price_Check++;
        Money = Money - Gacha_Price[Gacha_Price_Check];
    }
}
