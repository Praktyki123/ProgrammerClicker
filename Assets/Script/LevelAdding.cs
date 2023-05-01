using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LevelAdding : MonoBehaviour
{
    public TextMeshProUGUI StatusWyboru;
    public Image SquareOne;
    public Image SquareTwo;
    public Image SquareThree;
    public Image SquareFour;
    public Image SquareFive;
    [SerializeField]
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
    
    private void Start()
    {
    SquareIntOne = 0;
    SquareIntTwo = 0;
    SquareIntThree = 0;
    SquareIntFour = 0;
    SquareIntFive = 0;
        /*
        if (PlayerPrefs.GetInt("SquareIntOne") >= 1)
        {
            SquareIntOne = PlayerPrefs.GetInt("SquareIntOne");
        }
        if (PlayerPrefs.GetInt("SquareIntTwo") >= 1)
        {
            SquareIntTwo = PlayerPrefs.GetInt("SquareIntTwo");
        }
        if (PlayerPrefs.GetInt("SquareIntThree") >= 1)
        {
            SquareIntThree = PlayerPrefs.GetInt("SquareIntThree");
        }
        if (PlayerPrefs.GetInt("SquareIntFour") >= 1)
        {
            SquareIntFour = PlayerPrefs.GetInt("SquareIntFour");
        }
        if (PlayerPrefs.GetInt("SquareIntFive") >= 1)
        {
            SquareIntFive = PlayerPrefs.GetInt("SquareIntFive");
        }
        */
    }
    private void Update()
    {
        if(int.Parse(StatusWyboru.text) == 0)
        {
            if (SquareIntOne >= 5)
            {
                SquareOne.color = Color.green;
            }
            if (SquareIntOne >= 10)
            {
                SquareTwo.color = Color.green;
            }
            if (SquareIntOne >= 15)
            {
                SquareThree.color = Color.green;
            }
            if (SquareIntOne >= 20)
            {
                SquareFour.color = Color.green;
            }
            if (SquareIntOne >= 25)
            {
                SquareFive.color = Color.green;
            }
        }
        
    }
    public void AddLevel()
    {
        switch (int.Parse(StatusWyboru.text))
        {
            case 0:
                SquareIntOne += 1;
                PlayerPrefs.SetInt("SquareIntOne", SquareIntOne);
                Debug.Log(SquareIntOne);



                break;
            case 1:
                
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