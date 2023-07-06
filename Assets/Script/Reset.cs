using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetAll()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("SquareIntOne", 0);
        PlayerPrefs.SetInt("SquareIntTwo", 0);
    }
}
