using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    [SerializeField]
    private int NumberStart, NumberAdding;
    private void Start()
    {
        NumberStart = PlayerPrefs.GetInt("score");
        scoretext.text = NumberStart.ToString();
    }

    private void Update()
    {
        PlayerPrefs.SetInt("score", int.Parse(scoretext.text));
    }

    public void Score()
    {
       
   
            NumberStart = NumberStart + NumberAdding;
            scoretext.text = NumberStart.ToString();
        


    }
}
