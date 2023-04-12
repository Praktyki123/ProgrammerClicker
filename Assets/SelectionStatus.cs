using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SelectionStatus : MonoBehaviour
{
    public TextMeshProUGUI status;
    public TextMeshProUGUI item;
   
    void Start()
    {
        status.text = 0.ToString();
        item.text = "Skills";
    }

    public void Dodaj_jeden()
    {
        if (int.Parse(status.text) < 6)
        {
            status.text = (int.Parse(status.text) + 1).ToString();
        }
        aktualny_przedmiot();
    }
    public void Odejmij_jeden()
    {
        if(int.Parse(status.text) > 0)
        {
            status.text = (int.Parse(status.text) - 1).ToString();
        }
        aktualny_przedmiot();
    }

    public void aktualny_przedmiot()
    {
        switch (int.Parse(status.text))
        {
            case 0:
                item.text = "Skills";
                break;
            case 1:
                item.text = "Room";
                break;
            case 2:
                item.text = "Computer";
                break;
            case 3:
                item.text = "Desk";
                break;
            case 4:
                item.text = "Chair";
                break;
        }
    }

}