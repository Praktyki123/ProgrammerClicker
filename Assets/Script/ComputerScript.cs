using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerScript : MonoBehaviour
{

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public int x;
    void Update()
    {
        x = PlayerPrefs.GetInt("itemOne");
        if(x == 0)
        {
            btn1.interactable = true;
            btn2.interactable = false;
            btn3.interactable = false;
            btn4.interactable = false;
            btn5.interactable = false;
            btn6.interactable = false;
        }
        if(x == 1)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = false;
            btn4.interactable = false;
            btn5.interactable = false;
            btn6.interactable = false;
        }
        if(x == 2)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = true;
            btn4.interactable = false;
            btn5.interactable = false;
            btn6.interactable = false;
        }
        if(x == 3)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = true;
            btn4.interactable = true;
            btn5.interactable = false;
            btn6.interactable = false;
        }
        if(x == 4)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = true;
            btn4.interactable = true;
            btn5.interactable = true;
            btn6.interactable = false;
        }
        if(x == 5)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = true;
            btn4.interactable = true;
            btn5.interactable = true;
            btn6.interactable = true;
        }
    }
}
