using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour {

    static public int Buy_Button;

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

    // Use this for initialization
    void Start () {
        
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
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Buy_Button == 1) {
            Set_Gacha_Tong();
        }
    }
    //가챠통 구매 버튼 눌렸을 때
    public void Set_Gacha_Tong() {
        if (Buy_Button == 1) {
            if (Gacha_Tong_0_st == false)
            {
                Debug.Log("Gacha_Tong0 true");
                Buy_Button = 0;
                Gacha_Tong_0_st = true;
            }
            else if (Gacha_Tong_1_st == false)
            {
                Debug.Log("Gacha_Tong1 true");
                Buy_Button = 0;
                Gacha_Tong_1_st = true;
            }
            else if (Gacha_Tong_2_st == false)
            {
                Debug.Log("Gacha_Tong2 true");
                Buy_Button = 0;
                Gacha_Tong_2_st = true;
            }
            else if (Gacha_Tong_3_st == false)
            {
                Debug.Log("Gacha_Tong3 true");
                Buy_Button = 0;
                Gacha_Tong_3_st = true;
            }
            else if (Gacha_Tong_4_st == false)
            {
                Debug.Log("Gacha_Tong4 true");
                Buy_Button = 0;
                Gacha_Tong_4_st = true;
            }
            else if (Gacha_Tong_5_st == false)
            {
                Debug.Log("Gacha_Tong5 true");
                Buy_Button = 0;
                Gacha_Tong_5_st = true;
            }
            else if (Gacha_Tong_6_st == false)
            {
                Debug.Log("Gacha_Tong6 true");
                Buy_Button = 0;
                Gacha_Tong_6_st = true;
            }
            else if (Gacha_Tong_7_st == false)
            {
                Debug.Log("Gacha_Tong7 true");
                Buy_Button = 0;
                Gacha_Tong_7_st = true;
            }
            else if (Gacha_Tong_8_st == false)
            {
                Debug.Log("Gacha_Tong8 true");
                Buy_Button = 0;
                Gacha_Tong_8_st = true;
            }
            else if (Gacha_Tong_9_st == false)
            {
                Debug.Log("Gacha_Tong9 true");
                Buy_Button = 0;
                Gacha_Tong_9_st = true;
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
                if (Gacha_Tong_0_st == true)
                {
                    int Gacha_Ball;
                    
                    Gacha_Ball = Random.Range(0, Gacha_Initial[0]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong0 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[0] = Gacha_Initial[0] - 1;
                    }
                    else if (Gacha_Ball == 0) {
                        Debug.Log("Gacha_Tong0 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_0_st = false;
                        Gacha_Initial[0] = 9;
                    }
                }
                if (Gacha_Tong_1_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[1]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong1 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[1] = Gacha_Initial[1] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong1 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_1_st = false;
                        Gacha_Initial[1] = 9;
                    }
                }
                if (Gacha_Tong_2_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[2]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong2 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[2] = Gacha_Initial[2] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong3 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_2_st = false;
                        Gacha_Initial[2] = 9;
                    }
                }
                if (Gacha_Tong_3_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[3]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong3 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[3] = Gacha_Initial[3] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong4 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_3_st = false;
                        Gacha_Initial[3] = 9;
                    }
                }
                if (Gacha_Tong_4_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[4]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong4 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[4] = Gacha_Initial[4] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong4 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_4_st = false;
                        Gacha_Initial[4] = 9;
                    }
                }
                if (Gacha_Tong_5_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[5]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong5 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[5] = Gacha_Initial[5] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong5 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_5_st = false;
                        Gacha_Initial[5] = 9;
                    }
                }
                if (Gacha_Tong_6_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[6]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong6 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[6] = Gacha_Initial[6] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong6 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_6_st = false;
                        Gacha_Initial[6] = 9;
                    }
                }
                if (Gacha_Tong_7_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[7]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong7 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[7] = Gacha_Initial[7] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong7 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_7_st = false;
                        Gacha_Initial[7] = 9;
                    }
                }
                if (Gacha_Tong_8_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[8]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong8 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[8] = Gacha_Initial[8] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong8 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_8_st = false;
                        Gacha_Initial[8] = 9;
                    }
                }
                if (Gacha_Tong_9_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[9]);
                    if (Gacha_Ball != 0)
                    {
                        Debug.Log("Gacha_Tong9 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Initial[9] = Gacha_Initial[9] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Debug.Log("Gacha_Tong9 = ");
                        Debug.Log(Gacha_Ball);
                        Gacha_Tong_9_st = false;
                        Gacha_Initial[9] = 9;
                    }
                }
                break;

        }
    }
    
}
