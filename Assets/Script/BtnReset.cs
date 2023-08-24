using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnReset : MonoBehaviour
{


    public void ResetAll()
    {

        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("SquareIntOne", 0);
        PlayerPrefs.SetInt("SquareIntTwo", 0);
        PlayerPrefs.SetInt("SquareIntThree", 0);
        PlayerPrefs.SetInt("SquareIntFour", 0);
        PlayerPrefs.SetInt("SquareIntFive", 0);
        PlayerPrefs.SetInt("SquareIntSix", 0);
        PlayerPrefs.SetInt("SquareIntSeven", 0);

    }
}