using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LevelAdding : MonoBehaviour
{
    public TextMeshProUGUI LevelAdd;
    [SerializeField]
    private int NumberStart;
    private void Start()
    {

        LevelAdd.text = (PlayerPrefs.GetInt("leveladd")).ToString();
        if (LevelAdd.text == 0.ToString())
        {
            LevelAdd.text = 1.ToString();
        }
        NumberStart = PlayerPrefs.GetInt("level");
       
    }
    
    public void AddLevel()
    {
        NumberStart = NumberStart + int.Parse(LevelAdd.text);
  

    }
    
   
}
