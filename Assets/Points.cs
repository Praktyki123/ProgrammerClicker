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
    public void Score()
    {
       
   
            NumberStart = NumberStart + NumberAdding;
            scoretext.text = NumberStart.ToString();
        


    }
}
