using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SelectionStatus : MonoBehaviour
{
    public TextMeshProUGUI status;
    public TextMeshProUGUI item;
    public Image SquareOne;
    public Image SquareTwo;
    public Image SquareThree;
    public Image SquareFour;
    public Image SquareFive;

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
                item.text = "Skills"; // id = 0
                ClearSquare();
                break;
            case 1:
                item.text = "Room"; // id = 1
                ClearSquare();
                break;
            case 2:
                item.text = "Computer"; // id = 2
                ClearSquare();
                break;
            case 3:
                item.text = "Desk"; // id = 3
                ClearSquare();
                break;
            case 4:
                item.text = "Chair"; // id = 4
                ClearSquare();
                break;
        }
    }
    public void ClearSquare()
    {
        SquareOne.color = Color.red;
        SquareTwo.color = Color.red;
        SquareThree.color = Color.red;
        SquareFour.color = Color.red;
        SquareFive.color = Color.red;
    }

}
