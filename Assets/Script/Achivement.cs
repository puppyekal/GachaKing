using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achivement : MonoBehaviour
{

    public Text Achivement_EX_text;
    public Image Achivement_EX_Image;

    public Text Achivement1;
    public Text Achivement2;
    public Text Achivement3;
    public Text Achivement4;
    public Text Achivement5;
    public Text Achivement6;
    public Text Achivement7;
    public Text Achivement8;
    public Text Achivement9;
    public Text Achivement10;
    public Text Achivement11;
    public Text Achivement12;
    public Text Achivement13;
    public Text Achivement14;
    public Text Achivement15;

    static public int Achivement_EX_cnt = 0;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Acivement_EX(Ingame.Click_Num);
        
    }
    
    public void Acivement_EX(int click)
    {
        
        if (click <= 30) 
        {
            Achivement_EX_text.GetComponent<Text>().text = click + "/ 30";
            Achivement_EX_Image.fillAmount = (float)click / 30;
        }
       if (click == 30) 
        {
            Debug.Log(Achivement_EX_cnt);
            Achivement_EX_cnt = 1;
        }
    }
    
}
