using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingame : MonoBehaviour
{
    public Sprite[] Gacha_Tomg_Image = new Sprite[10];

    static public int Buy_Button;
    static public int Gacha_Tong_Num = 0;
    static public int Click_Num = 0;
    public int Gacha_Tong_Twice = 1;

    public int Gacha_Tong_Level = 1;


    //가챠통 남은수량%
    public Text Gacha_Tong_0_Text;
    public Text Gacha_Tong_1_Text;
    public Text Gacha_Tong_2_Text;
    public Text Gacha_Tong_3_Text;
    public Text Gacha_Tong_4_Text;
    public Text Gacha_Tong_5_Text;
    public Text Gacha_Tong_6_Text;
    public Text Gacha_Tong_7_Text;
    public Text Gacha_Tong_8_Text;
    public Text Gacha_Tong_9_Text;

    public Text Gacha_Automatic_Click_Text;

    //방꾸미기 구역
    public GameObject Area_0;
    public GameObject Area_1;
    public GameObject Area_2;
    public GameObject Area_3;
    public GameObject Area_4;

    //가챠통
    public GameObject Gacha_Tong_0;
    public GameObject Gacha_Tong_1;
    public GameObject Gacha_Tong_2;
    public GameObject Gacha_Tong_3;
    public GameObject Gacha_Tong_4;
    public GameObject Gacha_Tong_5;
    public GameObject Gacha_Tong_6;
    public GameObject Gacha_Tong_7;
    public GameObject Gacha_Tong_8;
    public GameObject Gacha_Tong_9;

    public GameObject Gacha_Automatic_Button;


    Image Gacha_Tong_0_Image;
    Image Gacha_Tong_1_Image;
    Image Gacha_Tong_2_Image;
    Image Gacha_Tong_3_Image;
    Image Gacha_Tong_4_Image;
    Image Gacha_Tong_5_Image;
    Image Gacha_Tong_6_Image;
    Image Gacha_Tong_7_Image;
    Image Gacha_Tong_8_Image;
    Image Gacha_Tong_9_Image;

    //방꾸미기 활성화
    public bool Area_st = false;

    //가챠통 상태
    public bool Gacha_Tong_0_st = false;
    public bool Gacha_Tong_1_st = false;
    public bool Gacha_Tong_2_st = false;
    public bool Gacha_Tong_3_st = false;
    public bool Gacha_Tong_4_st = false;
    public bool Gacha_Tong_5_st = false;
    public bool Gacha_Tong_6_st = false;
    public bool Gacha_Tong_7_st = false;
    public bool Gacha_Tong_8_st = false;
    public bool Gacha_Tong_9_st = false;

    public bool Gacha_Automatic_Click = false;
    public bool Gacha_Automatic_System = false;

    //가챠통 10개
    public int[] Gacha_Initial = new int[10];
    public int[] Gacha_Initial_Try = new int[10];
    public int[] Gacha_Initial_Zero = new int[10];

    //가챠볼 현재 레벨
    public int[] Gacha_Current_Level = new int[10];

    //가챠볼 개수
    public int[] Gacha_Ball_Num = new int[10];

    //가챠볼 1회 시도금액 
    public int[] Gacha_Ball_Try = new int[10];

    //가챠볼 당첨금액 
    public int[] Gacha_Ball_Zero = new int[10];

    //가챠볼 2번뽑기 스킬
    public int[] Gacha_Ball_Twice = new int[10];

    public float timer;
    public float waitingTime;

    public float timer2;
    public int waitingTime2;

    public float timer3;
    public int waitingTime3;


    // Use this for initialization
    void Start()
    {

        timer = 0.0f;
        timer2 = 0.0f;
        timer3 = 0.0f;

        waitingTime = 1000000f;
        waitingTime2 = 1000000;
        waitingTime3 = 1000000;

        Gacha_Tong_0.SetActive(false);
        Gacha_Tong_1.SetActive(false);
        Gacha_Tong_2.SetActive(false);
        Gacha_Tong_3.SetActive(false);
        Gacha_Tong_4.SetActive(false);
        Gacha_Tong_5.SetActive(false);
        Gacha_Tong_6.SetActive(false);
        Gacha_Tong_7.SetActive(false);
        Gacha_Tong_8.SetActive(false);
        Gacha_Tong_9.SetActive(false);


        Gacha_Tong_0_Image = Gacha_Tong_0.GetComponent<Image>();
        Gacha_Tong_1_Image = Gacha_Tong_1.GetComponent<Image>();
        Gacha_Tong_2_Image = Gacha_Tong_2.GetComponent<Image>();
        Gacha_Tong_3_Image = Gacha_Tong_3.GetComponent<Image>();
        Gacha_Tong_4_Image = Gacha_Tong_4.GetComponent<Image>();
        Gacha_Tong_5_Image = Gacha_Tong_5.GetComponent<Image>();
        Gacha_Tong_6_Image = Gacha_Tong_6.GetComponent<Image>();
        Gacha_Tong_7_Image = Gacha_Tong_7.GetComponent<Image>();
        Gacha_Tong_8_Image = Gacha_Tong_8.GetComponent<Image>();
        Gacha_Tong_9_Image = Gacha_Tong_9.GetComponent<Image>();

        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial[i] = 9;
        }
        for (int i = 0; i < 10; i++)
        {
            Gacha_Current_Level[i] = 9;
        }
        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial_Try[i] = 1;
        }

        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial_Zero[i] = 30000;
        }

        Gacha_Ball_Num[0] = 10000;
        Gacha_Ball_Num[1] = 20000;
        Gacha_Ball_Num[2] = 40000;
        Gacha_Ball_Num[3] = 80000;
        Gacha_Ball_Num[4] = 160000;
        Gacha_Ball_Num[5] = 320000;
        Gacha_Ball_Num[6] = 640000;
        Gacha_Ball_Num[7] = 1280000;
        Gacha_Ball_Num[8] = 2560000;
        Gacha_Ball_Num[9] = 2560000;

        Gacha_Ball_Try[0] = 1;
        Gacha_Ball_Try[1] = 4;
        Gacha_Ball_Try[2] = 16;
        Gacha_Ball_Try[3] = 64;
        Gacha_Ball_Try[4] = 128;
        Gacha_Ball_Try[5] = 256;
        Gacha_Ball_Try[6] = 512;
        Gacha_Ball_Try[7] = 1024;
        Gacha_Ball_Try[8] = 2048;
        Gacha_Ball_Try[9] = 2048;

        Gacha_Ball_Zero[0] = 30000;
        Gacha_Ball_Zero[1] = 160000;
        Gacha_Ball_Zero[2] = 960000;
        Gacha_Ball_Zero[3] = 6400000;
        Gacha_Ball_Zero[4] = 25600000;
        Gacha_Ball_Zero[5] = 102400000;
        Gacha_Ball_Zero[6] = 409600000;
        Gacha_Ball_Zero[7] = 1638400000;
        //Gacha_Ball_Zero[8] = 6553600000;
        //Gacha_Ball_Zero[9] = 99999999999;

        Gacha_Ball_Twice[0] = 1;
        Gacha_Ball_Twice[1] = 3;
        Gacha_Ball_Twice[2] = 5;
        Gacha_Ball_Twice[3] = 10;
        Gacha_Ball_Twice[4] = 15;
        Gacha_Ball_Twice[5] = 20;
        Gacha_Ball_Twice[6] = 25;
        Gacha_Ball_Twice[7] = 30;
        Gacha_Ball_Twice[8] = 50;
        Gacha_Ball_Twice[9] = 50;

    }

    // Update is called once per frame
    void Update()
    {
        Gacha_Tong_Level = Text_Event.Gacha_Level;
        Gacha_Tong_Twice = Text_Event.Passive_Skill;

        //Text_Event.Gacha_Level;
        Gacha_Tong_Initial();
        if (Buy_Button == 1)
        {
            Set_Gacha_Tong();
        }

        //가챠 자동클릭 레벨
        if (Text_Event.Active_Skill == 1)
        {
            waitingTime = 1;
        }
        else if (Text_Event.Active_Skill == 2)
        {

            waitingTime = 0.9f;
        }
        else if (Text_Event.Active_Skill == 3)
        {
            waitingTime = 0.8f;
        }
        else if (Text_Event.Active_Skill == 4)
        {
            waitingTime = 0.7f;

        }
        else if (Text_Event.Active_Skill == 5)
        {
            waitingTime = 0.6f;
        }
        else if (Text_Event.Active_Skill == 6)
        {
            waitingTime = 0.5f;
        }
        else if (Text_Event.Active_Skill == 7)
        {
            waitingTime = 0.4f;
        }
        else if (Text_Event.Active_Skill == 8)
        {
            waitingTime = 0.3f;
        }
        else if (Text_Event.Active_Skill == 9)
        {
            waitingTime = 0.2f;
        }

        //가챠 자동클릭2
        if (Text_Event.Active_Skill == 1)
        {
            waitingTime2 = 60;
        }
        else if (Text_Event.Active_Skill == 2)
        {

            waitingTime2 = 180;
        }
        else if (Text_Event.Active_Skill == 3)
        {
            waitingTime2 = 300;
        }
        else if (Text_Event.Active_Skill == 4)
        {
            waitingTime2 = 600;

        }
        else if (Text_Event.Active_Skill == 5)
        {
            waitingTime2 = 1200;
        }
        else if (Text_Event.Active_Skill == 6)
        {
            waitingTime2 = 1800;
        }
        else if (Text_Event.Active_Skill == 7)
        {
            waitingTime2 = 2400;
        }
        else if (Text_Event.Active_Skill == 8)
        {
            waitingTime2 = 2700;
        }
        else if (Text_Event.Active_Skill == 9)
        {
            waitingTime2 = 3000;
        }

        //가챠 자동클릭 3
        if (Text_Event.Active_Skill == 1)
        {
            waitingTime3 = 180;
        }
        else if (Text_Event.Active_Skill == 2)
        {

            waitingTime3 = 300;
        }
        else if (Text_Event.Active_Skill == 3)
        {
            waitingTime3 = 600;
        }
        else if (Text_Event.Active_Skill == 4)
        {
            waitingTime3 = 900;

        }
        else if (Text_Event.Active_Skill == 5)
        {
            waitingTime3 = 1800;
        }
        else if (Text_Event.Active_Skill == 6)
        {
            waitingTime3 = 2400;
        }
        else if (Text_Event.Active_Skill == 7)
        {
            waitingTime3 = 2700;
        }
        else if (Text_Event.Active_Skill == 8)
        {
            waitingTime3 = 3000;
        }
        else if (Text_Event.Active_Skill == 9)
        {
            waitingTime3 = 3600;
        }

        if (Gacha_Automatic_Click == true && Text_Event.Active_Skill != 0)
        {
            //Gacha_Automatic_Click_Text.GetComponent<Text>().text = waitingTime3 + "";

            if (Gacha_Automatic_System == true)
            {
                //가챠자동클릭 시스템
                timer += Time.deltaTime;
                if (timer > waitingTime)
                {
                    Gacha_System();
                    timer = 0;
                }
            }

            ////////////////////////////////

            timer2 += Time.deltaTime;
            if (timer2 > waitingTime2)
            {
                timer2 = 0;
                Gacha_Automatic_System = false;
                Debug.Log("Gacha_Automatic_System false");
            }

            ///////////////////////////////

            timer3 += Time.deltaTime;
            if (timer3 > waitingTime3)
            {
                timer3 = 0;
                Gacha_Automatic_System = false;
                Gacha_Automatic_Click = false;
                Gacha_Automatic_Button.SetActive(true);
                Debug.Log("Gacha_Automatic_Click false");
            }
        }
        
    }
    //가챠통 구매 버튼 눌렸을 때
    public void Set_Gacha_Tong()
    {
        if (Buy_Button == 1)
        {
            if (Gacha_Tong_0_st == false)
            {
                Debug.Log("Gacha_Tong0 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_0_st = true;
                Gacha_Tong_0.SetActive(true);
            }
            else if (Gacha_Tong_1_st == false)
            {
                Debug.Log("Gacha_Tong1 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_1_st = true;
                Gacha_Tong_1.SetActive(true);
            }
            else if (Gacha_Tong_2_st == false)
            {
                Debug.Log("Gacha_Tong2 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_2_st = true;
                Gacha_Tong_2.SetActive(true);
            }
            else if (Gacha_Tong_3_st == false)
            {
                Debug.Log("Gacha_Tong3 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_3_st = true;
                Gacha_Tong_3.SetActive(true);
            }
            else if (Gacha_Tong_4_st == false)
            {
                Debug.Log("Gacha_Tong4 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_4_st = true;
                Gacha_Tong_4.SetActive(true);
            }
            else if (Gacha_Tong_5_st == false)
            {
                Debug.Log("Gacha_Tong5 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_5_st = true;
                Gacha_Tong_5.SetActive(true);
            }
            else if (Gacha_Tong_6_st == false)
            {
                Debug.Log("Gacha_Tong6 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_6_st = true;
                Gacha_Tong_6.SetActive(true);
            }
            else if (Gacha_Tong_7_st == false)
            {
                Debug.Log("Gacha_Tong7 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_7_st = true;
                Gacha_Tong_7.SetActive(true);
            }
            else if (Gacha_Tong_8_st == false)
            {
                Debug.Log("Gacha_Tong8 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_8_st = true;
                Gacha_Tong_8.SetActive(true);
            }
            else if (Gacha_Tong_9_st == false)
            {
                Debug.Log("Gacha_Tong9 true");
                Buy_Button = 0;
                Gacha_Tong_Num++;
                Gacha_Tong_9_st = true;
                Gacha_Tong_9.SetActive(true);
            }
            else
            {
                Debug.Log("Gacha_Tong_All true");
                Buy_Button = 0;
                //가챠통 10개가 모두 존재할 때
            }
        }
    }
    //버튼
    public void PressKey(int nKey)
    {
        switch (nKey)
        {
            case 1:
                Debug.Log(1000);
                break;
            case 2:
                Debug.Log(2000);
                break;
            case 3:
                Debug.Log(3000);
                break;
            case 4:
                Debug.Log(4000);
                break;
            case 5:
                Debug.Log(5000);
                break;
            case 9999:
                Debug.Log(9999);
                if (Text_Event.Active_Skill != 0)
                {
                    Gacha_Automatic_Click = true;
                    Gacha_Automatic_System = true;
                    Gacha_Automatic_Button.SetActive(false);
                }
                break;
            case 10000:
                //방 눌렀을 때
                Gacha_System();
                break;

        }
    }
    //가챠통 정보 초기화
    public void Gacha_Tong_Initial(){
        //갸차통0
        if (Gacha_Tong_0_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[0] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[0] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[0] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[0] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_0_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통1
        if (Gacha_Tong_1_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[1] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[1] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[1] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[1] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_1_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통2
        if (Gacha_Tong_2_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[2] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[2] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[2] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[2] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_2_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통3
        if (Gacha_Tong_3_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[3] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[3] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[3] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[3] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_3_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통4
        if (Gacha_Tong_4_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[4] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[4] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[4] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[4] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_4_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통5
        if (Gacha_Tong_5_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[5] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[5] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[5] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[5] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_5_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통6
        if (Gacha_Tong_6_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[6] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[6] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[6] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[6] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_6_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통7
        if (Gacha_Tong_7_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[7] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[7] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[7] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[7] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_7_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통8
        if (Gacha_Tong_8_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[8] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[8] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[8] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[8] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_8_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
        //갸차통9
        if (Gacha_Tong_9_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Current_Level[9] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial[9] = Gacha_Ball_Num[i - 1];
                    Gacha_Initial_Try[9] = Gacha_Ball_Try[i - 1];
                    Gacha_Initial_Zero[9] = Gacha_Ball_Zero[i - 1];
                    Gacha_Tong_9_Image.sprite = Gacha_Tomg_Image[i - 1];
                }
            }
        }
    }
    //가챠 시스템
    public void Gacha_System()
    {
        //-------------
        Click_Num++;

        if (Gacha_Tong_0_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[0];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[0]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[0]);
                Gacha_Initial[0] = Gacha_Initial[0] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[0] + " Money + " + Gacha_Initial_Zero[0]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[0];
                Gacha_Tong_0_st = false;
                Gacha_Tong_0.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[0]);
                    Gacha_Initial[0] = Gacha_Initial[0] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[0] + " Money + " + Gacha_Initial_Zero[0]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[0];
                    Gacha_Tong_0_st = false;
                    Gacha_Tong_0.SetActive(false);
                }
            }

            Gacha_Tong_0_Text.GetComponent<Text>().text = 100 * Gacha_Initial[0] / Gacha_Current_Level[0] + "%";

        }
        if (Gacha_Tong_1_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[1];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[1]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[1]);
                Gacha_Initial[1] = Gacha_Initial[1] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[1] + " Money + " + Gacha_Initial_Zero[1]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[1];
                Gacha_Tong_1_st = false;
                Gacha_Tong_1.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[1]);
                    Gacha_Initial[1] = Gacha_Initial[1] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[1] + " Money + " + Gacha_Initial_Zero[1]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[1];
                    Gacha_Tong_1_st = false;
                    Gacha_Tong_1.SetActive(false);

                }

            }

            Gacha_Tong_1_Text.GetComponent<Text>().text = 100 * Gacha_Initial[1] / Gacha_Current_Level[1] + "%";
        }
        if (Gacha_Tong_2_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[2];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[2]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[2]);
                Gacha_Initial[2] = Gacha_Initial[2] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[2] + " Money + " + Gacha_Initial_Zero[2]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[2];
                Gacha_Tong_2_st = false;
                Gacha_Tong_2.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[2]);
                    Gacha_Initial[2] = Gacha_Initial[2] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[2] + " Money + " + Gacha_Initial_Zero[2]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[2];
                    Gacha_Tong_2_st = false;
                    Gacha_Tong_2.SetActive(false);

                }

            }
            Gacha_Tong_2_Text.GetComponent<Text>().text = 100 * Gacha_Initial[2] / Gacha_Current_Level[2] + "%";
        }
        if (Gacha_Tong_3_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[3];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[3]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[3]);
                Gacha_Initial[3] = Gacha_Initial[3] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[3] + " Money + " + Gacha_Initial_Zero[3]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[3];
                Gacha_Tong_3_st = false;
                Gacha_Tong_3.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[3]);
                    Gacha_Initial[3] = Gacha_Initial[3] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[3] + " Money + " + Gacha_Initial_Zero[3]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[3];
                    Gacha_Tong_3_st = false;
                    Gacha_Tong_3.SetActive(false);

                }
            }
            Gacha_Tong_3_Text.GetComponent<Text>().text = 100 * Gacha_Initial[3] / Gacha_Current_Level[3] + "%";
        }
        if (Gacha_Tong_4_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[4];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[4]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[4]);
                Gacha_Initial[4] = Gacha_Initial[4] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[4] + " Money + " + Gacha_Initial_Zero[4]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[4];
                Gacha_Tong_4_st = false;
                Gacha_Tong_4.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[4]);
                    Gacha_Initial[4] = Gacha_Initial[4] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[4] + " Money + " + Gacha_Initial_Zero[4]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[4];
                    Gacha_Tong_4_st = false;
                    Gacha_Tong_4.SetActive(false);

                }
            }
            Gacha_Tong_4_Text.GetComponent<Text>().text = 100 * Gacha_Initial[4] / Gacha_Current_Level[4] + "%";
        }
        if (Gacha_Tong_5_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[5];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[5]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[5]);
                Gacha_Initial[5] = Gacha_Initial[5] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[5] + " Money + " + Gacha_Initial_Zero[5]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[5];
                Gacha_Tong_5_st = false;
                Gacha_Tong_5.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[5]);
                    Gacha_Initial[5] = Gacha_Initial[5] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[5] + " Money + " + Gacha_Initial_Zero[5]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[5];
                    Gacha_Tong_5_st = false;
                    Gacha_Tong_5.SetActive(false);

                }
            }
            Gacha_Tong_5_Text.GetComponent<Text>().text = 100 * Gacha_Initial[5] / Gacha_Current_Level[5] + "%";
        }
        if (Gacha_Tong_6_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[6];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[6]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[6]);
                Gacha_Initial[6] = Gacha_Initial[6] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[6] + " Money + " + Gacha_Initial_Zero[6]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[6];
                Gacha_Tong_6_st = false;
                Gacha_Tong_6.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[6]);
                    Gacha_Initial[6] = Gacha_Initial[6] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[6] + " Money + " + Gacha_Initial_Zero[6]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[6];
                    Gacha_Tong_6_st = false;
                    Gacha_Tong_6.SetActive(false);

                }
            }
            Gacha_Tong_6_Text.GetComponent<Text>().text = 100 * Gacha_Initial[6] / Gacha_Current_Level[6] + "%";
        }
        if (Gacha_Tong_7_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[7];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[7]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[7]);
                Gacha_Initial[7] = Gacha_Initial[7] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[7] + " Money + " + Gacha_Initial_Zero[7]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[7];
                Gacha_Tong_7_st = false;
                Gacha_Tong_7.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[7]);
                    Gacha_Initial[7] = Gacha_Initial[7] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[7] + " Money + " + Gacha_Initial_Zero[7]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[7];
                    Gacha_Tong_7_st = false;
                    Gacha_Tong_7.SetActive(false);

                }
            }
            Gacha_Tong_7_Text.GetComponent<Text>().text = 100 * Gacha_Initial[7] / Gacha_Current_Level[7] + "%";
        }
        if (Gacha_Tong_8_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[8];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[8]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[8]);
                Gacha_Initial[8] = Gacha_Initial[8] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[8] + " Money + " + Gacha_Initial_Zero[8]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[8];
                Gacha_Tong_8_st = false;
                Gacha_Tong_8.SetActive(false);

            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[8]);
                    Gacha_Initial[8] = Gacha_Initial[8] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[8] + " Money + " + Gacha_Initial_Zero[8]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[8];
                    Gacha_Tong_8_st = false;
                    Gacha_Tong_8.SetActive(false);

                }
            }
            Gacha_Tong_8_Text.GetComponent<Text>().text = 100 * Gacha_Initial[8] / Gacha_Current_Level[8] + "%";
        }
        if (Gacha_Tong_9_st == true)
        {
            Text_Event.Money = Text_Event.Money - Gacha_Initial_Try[9];
            int Gacha_Ball;
            Gacha_Ball = Random.Range(0, Gacha_Initial[9]);
            if (Gacha_Ball != 0)
            {
                Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[9]);
                Gacha_Initial[9] = Gacha_Initial[9] - 1;
            }
            else if (Gacha_Ball == 0)
            {
                Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[9] + " Money + " + Gacha_Initial_Zero[9]);
                Gacha_Tong_Num--;
                Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[9];
                Gacha_Tong_9_st = false;
                Gacha_Tong_9.SetActive(false);
            }
            //일정확률시 두번
            int Twice;
            Twice = Random.Range(1, 100);
            if (Twice <= Gacha_Ball_Twice[Gacha_Tong_Twice] && Gacha_Tong_0_st == true)
            {
                if (Gacha_Ball != 0)
                {
                    Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[9]);
                    Gacha_Initial[9] = Gacha_Initial[9] - 1;
                }
                else if (Gacha_Ball == 0)
                {
                    Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball + " Money - " + Gacha_Initial_Try[9] + " Money + " + Gacha_Initial_Zero[9]);
                    Gacha_Tong_Num--;
                    Text_Event.Money = Text_Event.Money + Gacha_Initial_Zero[9];
                    Gacha_Tong_9_st = false;
                    Gacha_Tong_9.SetActive(false);
                }
            }
            Gacha_Tong_9_Text.GetComponent<Text>().text = 100 * Gacha_Initial[9] / Gacha_Current_Level[9] + "%";
        }
    }
}
