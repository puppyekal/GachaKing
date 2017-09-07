using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    public GameObject Menu;
    public GameObject Achivement;
    public GameObject Store;
    public GameObject Inventory;

    public GameObject Store_Skill;
    public GameObject Store_Home;
    public GameObject Store_Face;

    public GameObject Inven_Home;
    public GameObject Inven_Face;

    public Image Gacha_Num;//가챠통 수량 게이지
    public Image Gacha_Level;//가챠통 레벨 게이지
    public Image Active_Guage;

    public Button Gacha_Upgrade;
    public Button Gacha_Buy;
    public Button Active_Buy;

    int Check = 0;//0=메인, 1=업적, 2=상점, 3=인벤토리
    int Menu_Check = 0;//메뉴 확인

    // Use this for initialization
    void Start () {
        Menu.SetActive(false);
        Store.SetActive(false);
        Inventory.SetActive(false);
        Achivement.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        SetGuage(Ingame.Gacha_Tong_Num);


        if (Application.platform == RuntimePlatform.Android)//스마트폰 뒤로가기 인식
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (Menu_Check == 1)
                {
                    Menu.SetActive(false);
                    Menu_Check = 0;
                }
                if (Check == 1)
                {
                    Achivement.SetActive(false);
                    Check = 0;
                }
                else if (Check == 2)
                {
                    Store.SetActive(false);
                    Check = 0;
                }
                else if (Check == 3) 
                {
                    Inventory.SetActive(false);
                    Check = 0;
                }
            }
        }
        //가챠통 만렙 찍으면 버튼 비활성화
        if (Text_Event.Gacha_Level == 9) 
        {
            Gacha_Upgrade.interactable = false;
        }
        //액티브 만렙 찍으면 버튼 비활성화
        if (Text_Event.Active_Skill == 9) 
        {
            Active_Buy.interactable = false;
        }
        //가챠통 개수 10개면 버튼 비활성화
        if (Ingame.Gacha_Tong_Num == 10) 
        {
            Gacha_Buy.interactable = false;
        }
        else//다시 활성화
        {
            Gacha_Buy.interactable = true;
        }
    }
    //게이지 채우는 코드 float으로 해야함
    public void SetGuage(float temp)
    {
        Gacha_Num.fillAmount = temp / 10;
        Gacha_Level.fillAmount = (float)Text_Event.Gacha_Level / 9;
        Active_Guage.fillAmount = (float)Text_Event.Active_Skill / 9;
    }
    //메뉴
    public void Menu_Set_True()
    {
        if (Menu_Check == 0)
        {
            Menu.SetActive(true);
            Menu_Check = 1;
        }
        else if (Menu_Check == 1)
        {
            Menu.SetActive(false);
            Menu_Check = 0;
        }
    }
    //게임으로 돌아가기
    public void BackToGame()
    {
        Menu.SetActive(false);
        Menu_Check = 0;
    }
    //인생으로 돌아가기
    public void BackToLife()
    {
        Application.Quit();
    }

    public void Achivement_Set_True()//등급/업적
    {
        if (Check != 1) //등급/업적이 아니였을때 탭하면
        {
            Store.SetActive(false);
            Inventory.SetActive(false);

            Achivement.SetActive(true);

            Check = 1;
        }
        else if (Check == 1)
        {
            Achivement.SetActive(false);
            Check = 0;
        }
    }

    //상점
    public void Store_Set_True()
    {
        if (Check != 2) //상점이 아니였을때 탭하면
        {
            Inventory.SetActive(false);
            Achivement.SetActive(false);

            Store.SetActive(true);
            Store_Skill.SetActive(true);
            Store_Home.SetActive(false);
            Store_Face.SetActive(false);

            Check = 2;
        }
        else if(Check == 2)
        {
            Store.SetActive(false);
            Check = 0;
        }
    }
    public void Store_Skill_Setting()//성능
    {
        Store_Skill.SetActive(true);
        Store_Home.SetActive(false);
        Store_Face.SetActive(false);
    }
    public void Store_Home_Setting()//집값
    {
        Store_Skill.SetActive(false);
        Store_Home.SetActive(true);
        Store_Face.SetActive(false);
    }
    public void Store_Face_Setting()//외모
    {
        Store_Skill.SetActive(false);
        Store_Home.SetActive(false);
        Store_Face.SetActive(true);
    }

    //인벤토리
    public void Inventory_Set_True()
    {
        if (Check != 3) //인벤이 아니였을때 탭하면
        {
            Store.SetActive(false);
            Achivement.SetActive(false);

            Inventory.SetActive(true);
            Inven_Home.SetActive(true);
            Inven_Face.SetActive(false);

            Check = 3;
        }
        else if (Check == 3) 
        {
            Inventory.SetActive(false);
            Check = 0;
        }
    }
    public void Inven_Home_Setting()//이삿짐
    {
        Inven_Home.SetActive(true);
        Inven_Face.SetActive(false);
    }
    public void Inven_Face_Setting()//헌옷수거함
    {
        Inven_Home.SetActive(false);
        Inven_Face.SetActive(true);
    }
    /// <summary>
    /// 상점 구매
    /// </summary>
    public void Store_Gacha_Buy()
    {
        Store.SetActive(false);
        Check = 0;
        Ingame.Buy_Button = 1;
        //메인화면으로 갔다는 것을 알리기 위한 check
    }
    public void Store_Gacha_LVLUP()
    {
        Store.SetActive(false);
        Check = 0;
    }
    public void Inventory_Select()
    {
        Inventory.SetActive(false);
        Check = 0;
    }
    public void Active_Skill()
    {
        Store.SetActive(false);
        Check = 0;
    }
}
