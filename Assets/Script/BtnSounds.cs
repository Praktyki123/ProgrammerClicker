using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnSounds : MonoBehaviour
{
    public Sprite imgOn;
    public Sprite imgOff;
    public Button buttonS;
    public Slider slider;
    

    void Start()
    {
        
        if (PlayerPrefs.GetInt("btnGameSound") == 1)
        {
            buttonS.image.sprite = imgOn;
            slider.interactable = true;
        }
        else
        {
            buttonS.image.sprite = imgOff;
            slider.interactable = false;
        }
    }



    void Update()
    {

    }


    public void ChangeButtonImage()
    {

        if(buttonS.image.sprite == imgOff)
        {
        
            buttonS.image.sprite = imgOn;
            PlayerPrefs.SetInt("btnGameSound", 1);
            PlayerPrefs.SetFloat("MusicVolume", PlayerPrefs.GetFloat("PrzechowywanaWartosc1"));
            slider.value = PlayerPrefs.GetFloat("MusicVolume");
            slider.interactable = true;
        }
        else
        {
            buttonS.image.sprite = imgOff;
            PlayerPrefs.SetFloat("PrzechowywanaWartosc1", PlayerPrefs.GetFloat("MusicVolume"));
            PlayerPrefs.SetInt("btnGameSound", 0);
            PlayerPrefs.SetFloat("MusicVolume", 0.0F);
            slider.value = PlayerPrefs.GetFloat("MusicVolume");
            slider.interactable = false;
        }
    }
}
