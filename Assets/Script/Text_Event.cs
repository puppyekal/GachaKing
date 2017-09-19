using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Event : MonoBehaviour
{
    public Text Money_Text;

    public Text Gacha_Num_Text;
    public Text Gacha_Level_Text;
    public Text Active_Skill_Text;

    public Text Gacha_Level_Price_Text;
    public Text Gacha_Price_Text;
    public Text Active_Skill_Price_Text;


    //가챠 자동클릭 더블클릭레벨
    public Text Gacha_Automatic_Click_Text;
    public Text Gacha_Double_Click_Text;


    static public int Money = 10000000;
    public static int Gacha_Level = 1;
    public static int Active_Skill = 0;

    int Gacha_Price_Check = 0;//레벨에따른 판매가 변경 확인에 대한 체크
    long[] Gacha_Price = new long[] { 200, 800, 3200, 12800, 51200, 204000, 819200, 3276800, 13107200 };
    long[] Acive_Price = new long[] { 1, 200000, 400000, 600000, 800000, 1000000, 3000000, 5000000, 7000000, 9000000 };
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Money_Text.GetComponent<Text>().text = "" + Money;
        Gacha_Num_Text.GetComponent<Text>().text = Ingame.Gacha_Tong_Num + " / 10";
        Gacha_Level_Text.GetComponent<Text>().text = Gacha_Level + " / 9";
        Active_Skill_Text.GetComponent<Text>().text = Active_Skill + " / 9";

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
        switch (Active_Skill)
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
    }
    //내가 무슨 생각을 하고 코드를 이따위로 짰었을까
    //소지한 돈보다 구매가가 큰경우 구매 못하게 막음

    public void Store_Gacha_Buy()//가챠 구매시 돈 감소
    {
        if (Money - (int)Gacha_Price[Gacha_Price_Check] < 0)
        {

        }
        else
        {
            Money -= (int)Gacha_Price[Gacha_Price_Check];
        }
    }

    public void Store_Gacha_Level_Buy()//가챠 레벨업시 돈 감소
    {
        if (Money - (int)Gacha_Price[Gacha_Price_Check] < 0)
        {

        }
        else
        {
            Gacha_Level++;
            Gacha_Price_Check++;
            Money -= (int)Gacha_Price[Gacha_Price_Check];
        }
    }
    public void Store_Acive()
    {
        if (Money - (int)Acive_Price[Active_Skill] < 0)
        {

        }
        else
        {
            Money -= (int)Acive_Price[Active_Skill];
            Active_Skill++;
            //Gacha_Automatic_Click_Text.GetComponent<Text>().text = Active_Skill + "";
        }
    }
}
