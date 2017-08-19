using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Event : MonoBehaviour {
    public Text Money_Text;
    public Text Gacha_Num_Text;
    public Text Gacha_Level_Text;
    public Text Active_Skill_Text;
    public Text Passive_Skill_Text;

    public Text Gacha_Level_Price_Text;
    public Text Gacha_Price_Text;
    public Text Active_Skill_Price_Text;
    public Text Passive_Skill_Price_Text;


    //가챠 자동클릭 더블클릭레벨
    public Text Gacha_Automatic_Click_Text;
    public Text Gacha_Double_Click_Text;


    static public int Money = 10000000;
    public static int Gacha_Level = 1;
    public static int Active_Skill = 0;
    public static int Passive_Skill = 0;

    int Gacha_Price_Check = 0;//레벨에따른 판매가 변경 확인에 대한 체크
    long [] Gacha_Price = new long[] { 20000, 80000, 320000, 1280000, 5120000, 20480000, 81920000, 327680000, 1310720000 };
    long[] Acive_Price = new long[] { 500000, 1000000, 5000000, 10000000, 50000000, 100000000, 500000000, 1000000000, 5000000000 };
    long[] Passive_Price=new long[] { 500000, 1000000, 5000000, 10000000, 50000000, 100000000, 500000000, 1000000000, 5000000000 };
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
    void Update(){
        Money_Text.GetComponent<Text>().text = "" + Money;
        Gacha_Num_Text.GetComponent<Text>().text = Ingame.Gacha_Tong_Num + " / 10";
        Gacha_Level_Text.GetComponent<Text>().text = Gacha_Level + " / 9";
        Active_Skill_Text.GetComponent<Text>().text = Active_Skill + " / 9";
        Passive_Skill_Text.GetComponent<Text>().text = Passive_Skill + " / 9";


        switch (Gacha_Price_Check)
        {
            case 0:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 1:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 2:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 3:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 4:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 5:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 6:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 7:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
            case 8:
                Gacha_Level_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check + 1] + "₩";
                Gacha_Price_Text.GetComponent<Text>().text = Gacha_Price[Gacha_Price_Check] + "₩";
                break;
        }
        switch(Active_Skill)
        {
            case 0:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 1:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 2:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 3:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 4:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 5:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 6:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 7:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
            case 8:
                Active_Skill_Price_Text.GetComponent<Text>().text = Acive_Price[Active_Skill] + "₩";
                break;
        }
        switch (Passive_Skill)
        {
            case 0:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 1:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 2:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 3:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 4:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 5:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 6:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 7:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
            case 8:
                Passive_Skill_Price_Text.GetComponent<Text>().text = Passive_Price[Passive_Skill] + "₩";
                break;
        }
    }

    public void Store_Gacha_Buy()//가챠 구매시 돈 감소
    {
        Money = Money - (int)Gacha_Price[Gacha_Price_Check];
    }

    public void Store_Gacha_Level_Buy()//가챠 레벨업시 돈 감소
    {
        Gacha_Level++;
        Gacha_Price_Check++;
        Money = Money - (int)Gacha_Price[Gacha_Price_Check + 1];
    }
    public void Store_Acive()
    {
        Active_Skill++;
        Gacha_Automatic_Click_Text.GetComponent<Text>().text = Active_Skill + "";
    }
    public void Store_Passive()
    {
        Passive_Skill++;
        Gacha_Double_Click_Text.GetComponent<Text>().text = Passive_Skill + "";
    }
}
