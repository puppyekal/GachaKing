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
    //가챠통안 10000개
    public int[,] Gacha_Tong = new int[10, 10000];

    // Use this for initialization
    void Start () {
        for (int i = 0 ; i < 10; i++) {
            Initialize(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Gacha_Initial[i] = i;
        }

    }
	
	// Update is called once per frame
	void Update () {
  
    }

    //가챠통 초기화
    public void Initialize(int i) {
        for (int j = 0; j < 10000; j++)
        {
              Gacha_Tong [i, j] = j;
        }
      
    }
    //버튼
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
            case 10000:
                //방 눌렀을 때
                Debug.Log(10000);
                break;

        }
    }
    
}
