using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   
    
    int Check = 0;//0=메인, 1=업적, 2=상점, 3=인벤토리


    // Use this for initialization
    void Start () {
        Menu.SetActive(false);
        Store.SetActive(false);
        Inventory.SetActive(false);
        Achivement.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //메뉴
    public void Menu_Set_True()
    {
        Menu.SetActive(true);
    }
    //게임으로 돌아가기
    public void BackToGame()
    {
        Menu.SetActive(false);
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


}
