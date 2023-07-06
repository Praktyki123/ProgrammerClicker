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
        
        NumberAddingTxt.text = (PlayerPrefs.GetInt("pointsadd")).ToString();
        if(NumberAddingTxt.text == 0.ToString())
        {
            NumberAddingTxt.text = 1.ToString();
        }
        
        scoretext.text = NumberStart.ToString();
    }

    public void Update()
    {
        NumberStart = PlayerPrefs.GetInt("score");
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
        plusOne.color = new Color(0.8F, 0.8F, 0.56F, 1F);
        Debug.Log("Wait for 3 seconds");
        NumberStart = NumberStart + int.Parse(NumberAddingTxt.text);
        scoretext.text = NumberStart.ToString();
        MousePos();
        DoSomething();


    }
    async void DoSomething()
    {
        await Task.Delay(1000);
        Debug.Log("3 seconds later");
        plusOne.color = new Color(0.8F, 0.8F, 0.56F, 0F);
    }
}
