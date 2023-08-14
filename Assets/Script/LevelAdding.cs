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
    private int NumberStart;
    /*
     * Skills Id=0
     * Room Id=1
     * Computer Id=2
     * Desk Id=3
     * Chair Id=4
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
        Debug.Log(square);
        return square;
    }

    void Start()
    {
        SquareIntOne = PlayerPrefs.GetInt("SquareIntOne");
        SquareIntTwo = PlayerPrefs.GetInt("SquareIntTwo");
        SquareIntThree = PlayerPrefs.GetInt("SquareIntThree");
        SquareIntFour = PlayerPrefs.GetInt("SquareIntFour");
        SquareIntFive = PlayerPrefs.GetInt("SquareIntFive");
    }
    private void Update()
    {
        if (Koszt.text == "MAX")
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
        PlayerPrefs.SetInt("SquareIntOne", SquareIntOne);
        PlayerPrefs.SetInt("SquareIntTwo", SquareIntTwo);
        PlayerPrefs.SetInt("SquareIntThree", SquareIntThree);
        PlayerPrefs.SetInt("SquareIntFour", SquareIntFour);
        PlayerPrefs.SetInt("SquareIntFive", SquareIntFive);

        if (int.Parse(StatusWyboru.text) == 0)
        {
            Squares(SquareIntOne);
            koszt_status(5, 10, 15, 20, 25, 30);
        }
        if (int.Parse(StatusWyboru.text) == 1)
        {
            Squares(SquareIntTwo);
            koszt_status(5, 10, 15, 20, 25, 30);
        }
        if (int.Parse(StatusWyboru.text) == 2)
        {
            Squares(SquareIntThree);
            koszt_status(5, 10, 15, 20, 25, 30);
        }
        if (int.Parse(StatusWyboru.text) == 3)
        {
            Squares(SquareIntFour);
            koszt_status(5, 10, 15, 20, 25, 30);
        }
        if (int.Parse(StatusWyboru.text) == 4)
        {
            Squares(SquareIntFive);
            koszt_status(5, 10, 15, 20, 25, 30);
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