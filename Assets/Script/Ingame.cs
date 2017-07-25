using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour {

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
        Gacha_Tong_0_st = true;

        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial[i] = 99;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
  
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
                if (Gacha_Tong_0_st == false)
                {
                    Gacha_Tong_0_st = true;
                }
                else if (Gacha_Tong_1_st == false)
                {
                    Gacha_Tong_1_st = true;
                }
                else if (Gacha_Tong_2_st == false)
                {
                    Gacha_Tong_2_st = true;
                }
                else if (Gacha_Tong_3_st == false)
                {
                    Gacha_Tong_3_st = true;
                }
                else if (Gacha_Tong_4_st == false)
                {
                    Gacha_Tong_4_st = true;
                }
                else if (Gacha_Tong_5_st == false)
                {
                    Gacha_Tong_5_st = true;
                }
                else if (Gacha_Tong_6_st == false)
                {
                    Gacha_Tong_6_st = true;
                }
                else if (Gacha_Tong_7_st == false)
                {
                    Gacha_Tong_7_st = true;
                }
                else if (Gacha_Tong_8_st == false)
                {
                    Gacha_Tong_8_st = true;
                }
                else if (Gacha_Tong_9_st == false)
                {
                    Gacha_Tong_9_st = true;
                }
                else {
                    //가챠통 10개가 모두 존재할 때
                }
                break;
            case 10000:
                //방 눌렀을 때
                if (Gacha_Tong_0_st == true)
                {
                    int Gacha_Ball;
                    
                    Gacha_Ball = Random.Range(0, Gacha_Initial[0]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[0] = Gacha_Initial[0] - 1;
                    }
                    else if (Gacha_Ball == 0) {
                        Gacha_Tong_0_st = false;
                        Gacha_Initial[0] = 99;
                    }
                }
                if (Gacha_Tong_1_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[1]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[1] = Gacha_Initial[1] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_1_st = false;
                        Gacha_Initial[1] = 99;
                    }
                }
                if (Gacha_Tong_2_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[2]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[2] = Gacha_Initial[2] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_2_st = false;
                        Gacha_Initial[2] = 99;
                    }
                }
                if (Gacha_Tong_3_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[3]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[3] = Gacha_Initial[3] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_3_st = false;
                        Gacha_Initial[3] = 99;
                    }
                }
                if (Gacha_Tong_4_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[4]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[4] = Gacha_Initial[4] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_4_st = false;
                        Gacha_Initial[4] = 99;
                    }
                }
                if (Gacha_Tong_5_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[5]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[5] = Gacha_Initial[5] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_5_st = false;
                        Gacha_Initial[5] = 99;
                    }
                }
                if (Gacha_Tong_6_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[6]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[6] = Gacha_Initial[6] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_6_st = false;
                        Gacha_Initial[6] = 99;
                    }
                }
                if (Gacha_Tong_7_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[7]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[7] = Gacha_Initial[7] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_7_st = false;
                        Gacha_Initial[7] = 99;
                    }
                }
                if (Gacha_Tong_8_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[8]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[8] = Gacha_Initial[8] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_8_st = false;
                        Gacha_Initial[8] = 99;
                    }
                }
                if (Gacha_Tong_9_st == true)
                {
                    int Gacha_Ball;
                    Gacha_Ball = Random.Range(0, Gacha_Initial[9]);
                    if (Gacha_Ball != 0)
                    {
                        Gacha_Initial[9] = Gacha_Initial[9] - 1;
                    }
                    else if (Gacha_Ball == 0)
                    {
                        Gacha_Tong_9_st = false;
                        Gacha_Initial[9] = 99;
                    }
                }
                break;

        }
    }
    
}
