using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LevelAdding : MonoBehaviour
{
    public TextMeshProUGUI StatusWyboru;
    public TextMeshProUGUI Koszt;
    public Image SquareOne;
    public Image SquareTwo;
    public Image SquareThree;
    public Image SquareFour;
    public Image SquareFive;
    public Button UpgradeBtn;
    private ColorBlock theColor;
    [SerializeField]
    private TextMeshProUGUI Punkty;

    private int LevelAdd;
    public int SquareIntOne;
    public int SquareIntTwo;
    public int SquareIntThree;
    public int SquareIntFour;
    public int SquareIntFive;
    public int SquareIntSix;
    public int SquareIntSeven;
    public int SquareIntEight;
    public int LvlSkills;
    private int NumberStart;
    /*
        "Skills" id = 0
        "Room" id = 1
        "Computer" id = 2
        "Bed" id = 3
        "Desk" id = 4
        "Chair" id = 5
        "Furniture" id = 6
        "Decoration" id = 7
     */
    private void squares_color(int i)
    {
        if (int.Parse(Punkty.text) < i)
        {
            theColor = GetComponent<Button>().colors;
            theColor.normalColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.pressedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.selectedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.highlightedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            UpgradeBtn.colors = theColor;
        }
        else
        {
            theColor = GetComponent<Button>().colors;
            theColor.normalColor = new Color(1F, 1F, 1F, 1F);
            theColor.pressedColor = new Color(1F, 1F, 1F, 1F);
            theColor.selectedColor = new Color(1F, 1F, 1F, 1F);
            theColor.highlightedColor = new Color(1F, 1F, 1F, 1F);
            UpgradeBtn.colors = theColor;
        }
    }
    private void Squares(int i)
    {
        if (i >= 5)
        {
            SquareOne.color = Color.green;
        }
        if (i >= 10)
        {
            SquareTwo.color = Color.green;
        }
        if (i >= 15)
        {
            SquareThree.color = Color.green;
        }
        if (i >= 20)
        {
            SquareFour.color = Color.green;
        }
        if (i >= 25)
        {
            SquareFive.color = Color.green;
        }
    }

    private void koszt_status(int i0, int i1, int i2, int i3, int i4, int i5)
    {
        Koszt.text = i0.ToString();
        squares_color(int.Parse(Koszt.text));
        if (SquareOne.color == Color.green)
        {
            Koszt.text = i1.ToString();
            squares_color(int.Parse(Koszt.text));
        }
        if (SquareTwo.color == Color.green)
        {
            Koszt.text = i2.ToString();
            squares_color(int.Parse(Koszt.text));
        }
        if (SquareThree.color == Color.green)
        {
            Koszt.text = i3.ToString();
            squares_color(int.Parse(Koszt.text));
        }
        if (SquareFour.color == Color.green)
        {
            Koszt.text = i4.ToString();
            squares_color(int.Parse(Koszt.text));
        }
        if (SquareFive.color == Color.green)
        {
            Koszt.text = "MAX";
            theColor = GetComponent<Button>().colors;
            theColor.normalColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.pressedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.selectedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            theColor.highlightedColor = new Color(0.67F, 0.67F, 0.67F, 0.5F);
            UpgradeBtn.colors = theColor;
        }
    }
    private int buying_status(int i, int square)
    {
        if (int.Parse(Punkty.text) >= i)
        {

            Punkty.text = (int.Parse(Punkty.text) - i).ToString();
            square += 1;

        }

        return square;
    }
    private void CounterLvlItems(string i, string num)
    {
        int liczba1 = PlayerPrefs.GetInt(num);
        if (liczba1 >= 0)
        {
            PlayerPrefs.SetInt(i, 0);
        }
        if(liczba1 >= 5)
        {
            PlayerPrefs.SetInt(i, 1);
        }
        if (liczba1 >= 10)
        {
            PlayerPrefs.SetInt(i, 2);
        }
        if (liczba1 >= 15)
        {
            PlayerPrefs.SetInt(i, 3);
        }
        if (liczba1 >= 20)
        {
            PlayerPrefs.SetInt(i, 4);
        }
        if (liczba1 >= 25)
        {
            PlayerPrefs.SetInt(i, 5);
        }
    }
    void Start()
    {
        SquareIntOne = PlayerPrefs.GetInt("SquareIntOne");
        SquareIntTwo = PlayerPrefs.GetInt("SquareIntTwo");
        SquareIntThree = PlayerPrefs.GetInt("SquareIntThree");
        SquareIntFour = PlayerPrefs.GetInt("SquareIntFour");
        SquareIntFive = PlayerPrefs.GetInt("SquareIntFive");
        SquareIntSix = PlayerPrefs.GetInt("SquareIntSix");
        SquareIntSeven = PlayerPrefs.GetInt("SquareIntSeven");
        SquareIntEight = PlayerPrefs.GetInt("SquareIntEight");

        
    }
    private void Update()
    {
        PlayerPrefs.SetInt("SquareIntOne", SquareIntOne);
        PlayerPrefs.SetInt("SquareIntTwo", SquareIntTwo);
        PlayerPrefs.SetInt("SquareIntThree", SquareIntThree);
        PlayerPrefs.SetInt("SquareIntFour", SquareIntFour);
        PlayerPrefs.SetInt("SquareIntFive", SquareIntFive);
        PlayerPrefs.SetInt("SquareIntSix", SquareIntSix);
        PlayerPrefs.SetInt("SquareIntSeven", SquareIntSeven);
        PlayerPrefs.SetInt("SquareIntEight", SquareIntEight);

        if (Koszt.text == "MAX")
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
        
        CounterLvlItems("itemOne", "SquareIntOne");
        CounterLvlItems("itemTwo", "SquareIntTwo");
        CounterLvlItems("itemThree", "SquareIntThree");
        CounterLvlItems("itemFour", "SquareIntFour");
        CounterLvlItems("itemFive", "SquareIntFive");
        CounterLvlItems("itemSix", "SquareIntSix");
        CounterLvlItems("itemSeven", "SquareIntSeven");
        CounterLvlItems("itemEight", "SquareIntEight");
        /* for(int i=0; i <= 5; i++)
         {
             int liczba1 = PlayerPrefs.GetInt("SquareIntOne");
             PlayerPrefs.SetInt("itemOne", );
         } */



        if (int.Parse(StatusWyboru.text) == 0)
        {
            Squares(SquareIntOne);
            //  koszt_status(100, 200, 500, 1000, 2500, 10000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 1)
        {
            Squares(SquareIntTwo);
            // koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 2)
        {
            Squares(SquareIntThree);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 3)
        {
            Squares(SquareIntFour);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 4)
        {
            Squares(SquareIntFive);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 5)
        {
            Squares(SquareIntSix);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 6)
        {
            Squares(SquareIntSeven);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
        if (int.Parse(StatusWyboru.text) == 7)
        {
            Squares(SquareIntEight);
            //  koszt_status(10, 25, 100, 250, 500, 1000);
            koszt_status(1, 5, 10, 15, 20, 25);
        }
    }
    public void AddLevel()
    {
        switch (int.Parse(StatusWyboru.text))
        {
            case 0:
                SquareIntOne = buying_status(int.Parse(Koszt.text), SquareIntOne);
                break;
            case 1:
                SquareIntTwo = buying_status(int.Parse(Koszt.text), SquareIntTwo);
                break;
            case 2:
                SquareIntThree = buying_status(int.Parse(Koszt.text), SquareIntThree);
                break;
            case 3:
                SquareIntFour = buying_status(int.Parse(Koszt.text), SquareIntFour);
                break;
            case 4:
                SquareIntFive = buying_status(int.Parse(Koszt.text), SquareIntFive);
                break;
            case 5:
                SquareIntSix = buying_status(int.Parse(Koszt.text), SquareIntSix);
                break;
            case 6:
                SquareIntSeven = buying_status(int.Parse(Koszt.text), SquareIntSeven);
                break;
            case 7:
                SquareIntEight = buying_status(int.Parse(Koszt.text), SquareIntEight);
                break;
        }
    }
   
    public void ClearSquare()
    {
        SquareOne = SquareOne.GetComponent<Image>();
        SquareTwo = SquareTwo.GetComponent<Image>();
        SquareThree = SquareThree.GetComponent<Image>();
        SquareFour = SquareFour.GetComponent<Image>();
        SquareFive = SquareFive.GetComponent<Image>();
    }

}
