using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour
{

    static public int Buy_Button;
    static public int Gacha_Tong_Num = 0;
    public int Gacha_Tong_Level = 1;

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


    //가챠통 10개
    public int[] Gacha_Initial = new int[10];

    //가챠볼 개수
    public int[] Gacha_Ball_Num = new int[10];


    // Use this for initialization
    void Start()
    {
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

        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial[i] = 9;
        }

        Gacha_Ball_Num[0] = 9;
        Gacha_Ball_Num[1] = 19;
        Gacha_Ball_Num[2] = 29;
        Gacha_Ball_Num[3] = 39;
        Gacha_Ball_Num[4] = 49;
        Gacha_Ball_Num[5] = 59;
        Gacha_Ball_Num[6] = 69;
        Gacha_Ball_Num[7] = 79;
        Gacha_Ball_Num[8] = 89;
        Gacha_Ball_Num[9] = 99;

    }

    // Update is called once per frame
    void Update()
    {
        Gacha_Tong_Level = Text_Event.Gacha_Level;

        //갸차통0
        if (Gacha_Tong_0_st == false)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (Gacha_Tong_Level == i)
                {
                    Gacha_Initial[0] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[1] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[2] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[3] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[4] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[5] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[6] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[7] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[8] = Gacha_Ball_Num[i - 1];
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
                    Gacha_Initial[9] = Gacha_Ball_Num[i - 1];
                }
            }
        }

        if (Buy_Button == 1)
        {
            Set_Gacha_Tong();
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
            case 10000:
                //방 눌렀을 때

               
                //-------------

                if (Gacha_Tong_0_st == true)
                {
                    int Gacha_Ball;

                    Gacha_Ball = Random.Range(0, Gacha_Initial[0]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = "+ Gacha_Ball);
                        Gacha_Initial[0] = Gacha_Initial[0] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong0 남은개수 = " + Gacha_Initial[0] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_0_st = false;
                        Gacha_Tong_0.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[0] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_1_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[1]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[1] = Gacha_Initial[1] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong1 남은개수 = " + Gacha_Initial[1] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_1_st = false;
                        Gacha_Tong_1.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[1] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_2_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[2]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[2] = Gacha_Initial[2] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong2 남은개수 = " + Gacha_Initial[2] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_2_st = false;
                        Gacha_Tong_2.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[2] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_3_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[3]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[3] = Gacha_Initial[3] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong3 남은개수 = " + Gacha_Initial[3] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_3_st = false;
                        Gacha_Tong_3.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[3] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_4_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[4]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[4] = Gacha_Initial[4] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong4 남은개수 = " + Gacha_Initial[4] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_4_st = false;
                        Gacha_Tong_4.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[4] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_5_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[5]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[5] = Gacha_Initial[5] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong5 남은개수 = " + Gacha_Initial[5] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_5_st = false;
                        Gacha_Tong_5.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[5] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_6_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[6]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[6] = Gacha_Initial[6] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong6 남은개수 = " + Gacha_Initial[6] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_6_st = false;
                        Gacha_Tong_6.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[6] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_7_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[7]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[7] = Gacha_Initial[7] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong7 남은개수 = " + Gacha_Initial[7] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_7_st = false;
                        Gacha_Tong_7.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[7] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_8_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[8]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[8] = Gacha_Initial[8] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong8 남은개수 = " + Gacha_Initial[8] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_8_st = false;
                        Gacha_Tong_8.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[8] = Gacha_Ball_Num[9];
                        }
                    }
                }
                if (Gacha_Tong_9_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[9]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Initial[9] = Gacha_Initial[9] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong9 남은개수 = " + Gacha_Initial[9] + " 뽑힌숫자 = " + Gacha_Ball);
                        Gacha_Tong_Num--;
                        Gacha_Tong_9_st = false;
                        Gacha_Tong_9.SetActive(false);
                        if (Gacha_Tong_Level == 1)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[0];
                        }
                        else if (Gacha_Tong_Level == 2)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[1];
                        }
                        else if (Gacha_Tong_Level == 3)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[2];
                        }
                        else if (Gacha_Tong_Level == 4)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[3];
                        }
                        else if (Gacha_Tong_Level == 5)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[4];
                        }
                        else if (Gacha_Tong_Level == 6)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[5];
                        }
                        else if (Gacha_Tong_Level == 7)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[6];
                        }
                        else if (Gacha_Tong_Level == 8)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[7];
                        }
                        else if (Gacha_Tong_Level == 9)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[8];
                        }
                        else if (Gacha_Tong_Level == 10)
                        {
                            Gacha_Initial[9] = Gacha_Ball_Num[9];
                        }
                    }
                }
                break;

        }
    }

}
