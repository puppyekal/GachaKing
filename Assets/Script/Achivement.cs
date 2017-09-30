using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achivement : MonoBehaviour
{
    public Text Achivement_Class_Text;
    public Text Achivement_Class_Information;
    

    public Text Achivement_EX_text;
    public Image Achivement_EX_Image;
    public Text Achivement_Time_EX_text;
    public Image Achivement_Time_EX_Image;

    public Text Achivement1;
    public Image Achivement1_Guage;
    public Text Achivement2;
    public Image Achivement2_Guage;
    public Text Achivement3;
    public Image Achivement3_Guage;
    public Text Achivement4;
    public Image Achivement4_Guage;
    public Text Achivement5;
    public Image Achivement5_Guage;
    public Text Achivement6;
    public Image Achivement6_Guage;
    public Text Achivement7;
    public Image Achivement7_Guage;
    public Text Achivement8;
    public Image Achivement8_Guage;
    public Text Achivement9;
    public Image Achivement9_Guage;
    public Text Achivement10;
    public Image Achivement10_Guage;
    public Text Achivement11;
    public Image Achivement11_Guage;
    public Text Achivement12;
    public Image Achivement12_Guage;
    public Text Achivement13;
    public Image Achivement13_Guage;
    public Text Achivement14;
    public Image Achivement14_Guage;
    public Text Achivement15;
    public Image Achivement15_Guage;
    public Text Achivement16;
    public Image Achivement16_Guage;

    public static int Achivement_Class = 0;//업적 개수 카운팅

    static public int Achivement_EX_cnt = 0;
    static public int Achivement_Time_EX_cnt = 0;

    static public int Click_Cnt = 0;
    static public int Buy_Item = 0;
    static public float Play_Time = 0f;
    static public float Play_Time_NonStop = 0f;

    // Use this for initialization
    void Start()
    {
        Play_Time_NonStop = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Acivement_EX(Ingame.Click_Num);

        Class(Achivement_Class);

        Play_Time += Time.deltaTime;
        Play_Time_NonStop += Time.deltaTime;

        Play_Time_Ach(Play_Time);

        Click_Cnt_Func(Ingame.Click_Num);
        Buy_Item_Func(Home.Item_Cnt); 
    }

    public void Click_Cnt_Func(int Click)
    {
        if(Click<=100000)
        {

        }
        else if(Click<=500000)
        {

        }
        else if(Click<=1000000)
        {

        }
        else if(Click<=5000000)
        {

        }

        if(Click==100000)
        {

        }
        if(Click==500000)
        {

        }
        if(Click==1000000)
        {

        }
        if(Click==5000000)
        {

        }
    }

    public void Buy_Item_Func(int Item_Cnt)
    {
        if (Item_Cnt==1)
        {

        }
        if (Item_Cnt==5)
        {

        }
        if(Item_Cnt==10)
        {

        }
    }

    public void Acivement_EX(int click)
    {
        if (click <= 30) 
        {
            Achivement_EX_text.GetComponent<Text>().text = click + " / 30";
            Achivement_EX_Image.fillAmount = (float)click / 30;
        }
       if (click == 30) 
        {
            Achivement_EX_cnt = 1;
        }
        if (click >= 30) {
            Achivement_EX_text.GetComponent<Text>().text = "30" + " / 30";
            Achivement_EX_Image.fillAmount = (float)click / 30;
            Achivement_EX_cnt = 1;
        }
    }
    public void Play_Time_Ach(float time)
    {
        if ((int)time <= 15) 
        {
            Achivement_Time_EX_text.GetComponent<Text>().text = (int)time + " / 15";
            Achivement_Time_EX_Image.fillAmount = (float)time / 15;
        }
        if ((int)time == 15) 
        {
            Achivement_Time_EX_cnt = 1;
        }
        if ((int)time > 15) {
            Achivement_Time_EX_cnt = 1;
        }
    }

    public void Class(int temp)
    {
        switch(temp)
        {
            case 0:
                Achivement_Class_Text.GetComponent<Text>().text = "초짜";
                break;
            case 1:
                Achivement_Class_Text.GetComponent<Text>().text = "늒비";
                break;
            case 2:
                Achivement_Class_Text.GetComponent<Text>().text = "겜잘알";
                break;
            case 4:
                Achivement_Class_Text.GetComponent<Text>().text = "고인물";
                break;
            case 8:
                Achivement_Class_Text.GetComponent<Text>().text = "가챠의 달인";
                break;
            case 10:
                Achivement_Class_Text.GetComponent<Text>().text = "가챠조아";
                break;
            case 13:
                Achivement_Class_Text.GetComponent<Text>().text = "써근물";
                break;
            case 16:
                Achivement_Class_Text.GetComponent<Text>().text = "가챠왕";
                break;

        }
    }
}
