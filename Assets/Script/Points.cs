using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI NumberAddingTxt;
    public TextMeshProUGUI plusOne;
    [SerializeField]
    private int NumberStart;
    public void Start()
    {
        NumberStart = PlayerPrefs.GetInt("score");
        scoretext.text = NumberStart.ToString();
        NumberAddingTxt.text = (PlayerPrefs.GetInt("pointsadd")).ToString();
        
        if (NumberAddingTxt.text == 0.ToString())
        {
            NumberAddingTxt.text = 1.ToString();
        }
       
        
    }

    public void Update()
    {
        
        PlayerPrefs.SetInt("score", int.Parse(scoretext.text));
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos2 = Input.mousePosition;
            if (mousePos2 == plusOne.transform.position)
            {
                Score();
            }
        }

    }

    public void MousePos()
    {
        plusOne.text = "+" + NumberAddingTxt.text;
        Vector3 mousePos = Input.mousePosition;
        plusOne.transform.position = new Vector2(mousePos.x, mousePos.y);

    }
   
    public void Score()
    {
        NumberStart = PlayerPrefs.GetInt("score");
        float[] Tab = { 0.9608F, 0.1569F, 0.5686F, 1F, 
            0.1529F, 0.8941F, 0.9608F, 1F, 
            0.7412F, 0.9608F, 0.1529F, 1F, 
            0.9608F, 0.4039F, 0.1529F, 1F, 
            0.4392F, 0.1529F, 0.9608F, 1F, 
            0.9608F, 0.1529F, 0.3059F, 1F, 
            0.1529F, 0.9608F, 0.3059F, 1F, 
            0.9608F, 0.6588F, 0.1529F, 1F, 
            0.9608F, 0.1529F, 0.1529F, 1F, 
            0.1529F, 0.1882F, 0.9608F, 1F, 
            0.1529F, 0.4235F, 0.9608F, 1F, 
            0.9608F, 0.7765F, 0.1529F, 1F, 
            0.2863F, 0.1529F, 0.9608F, 1F };
        //52 - Tab.length
        int[] Tab2 = {0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48};
        //13 - Tab2.length
        int randomNumber = Random.Range(0, 13);
        float liczba = Tab[Tab2[randomNumber]];
        float liczba2 = Tab[Tab2[randomNumber] + 1];   
        float liczba3 = Tab[Tab2[randomNumber] + 2];
        float liczba4 = Tab[Tab2[randomNumber] + 3];
        plusOne.color = new Color(liczba, liczba2, liczba3, liczba4);
        
        NumberStart = NumberStart + int.Parse(NumberAddingTxt.text);
        scoretext.text = NumberStart.ToString();
        MousePos();
        DoSomething();

        
    }
    async void DoSomething()
    {
        
        await Task.Delay(1000);
        
        plusOne.color = new Color(0.8F, 0.8F, 0.56F, 0F);
    }
}
