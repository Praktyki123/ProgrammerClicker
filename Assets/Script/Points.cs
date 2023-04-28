using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI NumberAddingTxt;
    
    [SerializeField]
    private int NumberStart;
    private void Start()
    {
        
        NumberAddingTxt.text = (PlayerPrefs.GetInt("pointsadd")).ToString();
        if(NumberAddingTxt.text == 0.ToString())
        {
            NumberAddingTxt.text = 1.ToString();
        }
        NumberStart = PlayerPrefs.GetInt("score");
        scoretext.text = NumberStart.ToString();
    }

    private void Update()
    {
        PlayerPrefs.SetInt("score", int.Parse(scoretext.text));
    }

    public void Score()
    {
   
            NumberStart = NumberStart + int.Parse(NumberAddingTxt.text);
            scoretext.text = NumberStart.ToString();
        
    }
}
