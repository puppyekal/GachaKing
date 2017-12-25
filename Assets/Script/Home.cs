using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour {

    public Button Store_item1;
    public Button Store_item2;
    public Button Store_item3;
    public Button Store_item4;
    public Button Store_item5;
    public Button Store_item6;
    public Button Store_item7;
    public Button Store_item8;
    public Button Store_item9;
    public Button Store_item10;
    public Button Store_item11;
    public Button Store_item12;
    public Button Store_item13;
    public Button Store_item14;
    public Button Store_item15;
    public Button Store_item16;

    public GameObject Room;
    public GameObject[] Area = new GameObject[30];
    public int[] Area_data = new int[30];
    public int[] Area_Inven_data = new int[30];
    public GameObject[] Inventory_Item = new GameObject[21];
    public int[] Inventory_Item_data = new int[21];
    public Sprite[] Store_item_Image = new Sprite[16];

    public Sprite gachaball;
    public Text Money_Text;

    static public int Item_Cnt;
    public int s;//상점에서 눌린 번호
    public int iv;//인벤에서 눌린 번호
    public int Si;//바꾸려는 이미지 번호
    public int Im;//인벤번호

    // Use this for initialization
    void Start() {
        Item_Cnt = -1;
        s = -1;
        for (int i = 0; i < 21; i++)
        {
            Inventory_Item_data[i] = -1;
        }
        for (int i = 0; i < 30; i++)
        {
            Area_data[i] = -1;
        }
        for (int i = 0; i < 30; i++)
        {
            Area_Inven_data[i] = -1;
        }
        /*
        //업적 해금 전까지 버튼 비활성화
        Store_item1.interactable = false;
        Store_item2.interactable = false;
        Store_item3.interactable = false;
        Store_item4.interactable = false;
        Store_item5.interactable = false;
        Store_item6.interactable = false;
        Store_item7.interactable = false;

    
        //상점에서 구매 전까지 버튼 미생성 
        Inventory_Item1.SetActive(false);
        Inventory_Item2.SetActive(false);
        Inventory_Item3.SetActive(false);
        Inventory_Item4.SetActive(false);
        Inventory_Item5.SetActive(false);
        Inventory_Item6.SetActive(false);
        Inventory_Item7.SetActive(false);
        */

    }

    // Update is called once per frame
    void Update() {
        
        //업적 해금시 버튼 활성화
        /*
        if (Achivement.Achivement_EX_cnt == 1)
        {
            Store_item1.interactable = true;
            Store_item2.interactable = true;
            Store_item3.interactable = true;
            Store_item4.interactable = true;
            Store_item5.interactable = true;
            Store_item6.interactable = true;
            Store_item7.interactable = true;

            Achivement.Achivement_EX_cnt = 2;
        }
        */
        Money_Text.GetComponent<Text>().text = "" + Text_Event.Money;
    }
    public void PressKey(int nKey)
    {
        switch (nKey)
        {
         
            case 1:
                if (Text_Event.Money > 3333)
                {

                    s = 1;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Text_Event.Money -= 3333;
                }
                break;
            case 2:
                if (Text_Event.Money > 3333)
                {
                    s = 2;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 3333;
                }
                break;
            case 3:
                if (Text_Event.Money > 3333)
                {
                    s = 3;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 3333;
                }
                break;
            case 4:
                if (Text_Event.Money > 15000)
                {
                    s = 4;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 15000;
                }
                break;
            case 5:
                if (Text_Event.Money > 42000)
                {
                    s = 5;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 42000;
                }
                break;
            case 6:
                if (Text_Event.Money > 100000)
                {
                    s = 6;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 100000;
                }
                break;
            case 7:
                if (Text_Event.Money > 500000)
                {
                    s = 7;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 500000;
                }
                break;
            case 8:
                if (Text_Event.Money > 120000)
                {
                    s = 8;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 120000;
                }
                break;
            case 9:
                if (Text_Event.Money > 200000)
                {
                    s = 9;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 200000;
                }
                break;
            case 10:
                if (Text_Event.Money > 360000)
                {
                    s = 10;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 360000;
                }
                break;
            case 11:
                if (Text_Event.Money > 500000)
                {
                    s = 11;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 500000;
                }
                break;
            case 12:
                if (Text_Event.Money > 700000)
                {
                    s = 12;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 700000;
                }
                break;
            case 13:
                if (Text_Event.Money > 900000)
                {
                    s = 13;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 900000;
                }
                break;
            case 14:
                if (Text_Event.Money > 1000000)
                {
                    s = 14;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 1000000;
                }
                break;
            case 15:
                if (Text_Event.Money > 500)
                {
                    s = 15;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 500;
                }
                break;
            case 16:
                if (Text_Event.Money > 3500000)
                {
                    s = 16;
                    Item_Cnt++;
                    Inventory_Item[Item_Cnt].GetComponent<Image>().sprite = Store_item_Image[s - 1];
                    Inventory_Item_data[Item_Cnt] = s - 1;
                    Inventory_Item[Item_Cnt].SetActive(true);
                    Debug.Log(Item_Cnt + "___" + Inventory_Item_data[Item_Cnt]);
                    Text_Event.Money -= 3500000;
                }
                break;
        }
    }
    public void PressInven(int nKey)
    {
        switch (nKey)
        {

            case 1:
                iv = 0;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 2:
                iv = 1;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 3:
                iv = 2;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 4:
                iv = 3;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 5:
                iv = 4;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 6:
                iv = 5;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 7:
                iv = 6;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 8:
                iv = 7;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 9:
                iv = 8;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 10:
                iv = 9;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 11:
                iv = 10;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 12:
                iv =11;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 13:
                iv = 12;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 14:
                iv = 13;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 15:
                iv = 14;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 16:
                iv = 15;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 17:
                iv = 16;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 18:
                iv = 17;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 19:
                iv = 18;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 20:
                iv = 19;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
            case 21:
                iv = 20;
                Im = iv;
                Si = Inventory_Item_data[iv];
                Debug.Log(Inventory_Item_data[iv]);
                Areasetactive();
                Inven_data_check(iv);
                break;
        }
    }
    public void Inven_data_check(int k)
    {
        int i;
        for (i = 0; i < 30; i++)
        {
            if (Area_Inven_data[i] == k) {
                Area_Inven_data[i] = -1;
                Area_data[i] = -1;
                Area[i].GetComponent<Image>().sprite = gachaball;
            }
        }
    }
    public void Areasetactive() {
        int i;
        for (i = 0; i < 30; i++) {
            Area[i].SetActive(true);
        }
    }
    public void Areasetactivefalse()
    {
        int i;
        for (i = 0; i < 30; i++)
        {
            if (Area_data[i] == -1)
            {
                Area[i].SetActive(false);
            }
        }
    }
    public void PressArea(int nKey)
    {
        switch (nKey)
        {

            case 1:
                iv = 0;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 2:
                iv = 1;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 3:
                iv = 2;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 4:
                iv = 3;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 5:
                iv = 4;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 6:
                iv = 5;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 7:
                iv = 6;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 8:
                iv = 7;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 9:
                iv = 8;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 10:
                iv = 9;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 11:
                iv = 10;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 12:
                iv = 11;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 13:
                iv = 12;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 14:
                iv = 13;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 15:
                iv = 14;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 16:
                iv = 15;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 17:
                iv = 16;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 18:
                iv = 17;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 19:
                iv = 18;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 20:
                iv = 19;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 21:
                iv = 20;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 22:
                iv = 21;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 23:
                iv = 22;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 24:
                iv = 23;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 25:
                iv = 24;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 26:
                iv = 25;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 27:
                iv = 26;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 28:
                iv = 27;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 29:
                iv = 28;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
            case 30:
                iv = 29;
                if (Si != -1)
                {
                    Area[iv].GetComponent<Image>().sprite = Store_item_Image[Si];
                    Area_data[iv] = Si;
                    Area_Inven_data[iv] = Im;
                    Si = -1;
                    Debug.Log(Area_data[iv]);
                }
                Areasetactivefalse();
                break;
        }
    }

    /*
    public void Item1_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item1.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item1.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item2_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item2.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item2.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item3_Button()
    {
        if (Text_Event.Money - 33333 < 0)
        {

        }
        else
        {
            Inventory_Item3.SetActive(true);
            Text_Event.Money -= 33333;
            Store_item3.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item4_Button()
    {
        if (Text_Event.Money - 150000 < 0)
        {

        }
        else
        {
            Inventory_Item4.SetActive(true);
            Text_Event.Money -= 150000;
            Store_item4.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item5_Button()
    {
        if (Text_Event.Money - 4200 < 0)
        {

        }
        else
        {
            Inventory_Item5.SetActive(true);
            Text_Event.Money -= 4200;
            Store_item5.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item6_Button()
    {
        if (Text_Event.Money - 100000 < 0)
        {

        }
        else
        {
            Inventory_Item6.SetActive(true);
            Text_Event.Money -= 100000;
            Store_item6.interactable = false;
            Item_Cnt++;
        }
    }
    public void Item7_Button()
    {
        if (Text_Event.Money - 500000 < 0)
        {

        }
        else
        {
            Inventory_Item7.SetActive(true);
            Text_Event.Money -= 500000;
            Store_item7.interactable = false;
            Item_Cnt++;
        }
    }
    */

}
