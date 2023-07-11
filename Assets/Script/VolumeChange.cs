using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class VolumeChange : MonoBehaviour
{
    public AudioSource VolumeMusic;
    public AudioSource GameMusic1;
    public AudioSource GameMusic2;
    public Slider slider;
    
   
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume");
        
    }
    void Update()
    {
       
        PlayerPrefs.SetFloat("MusicVolume", slider.value);
       
    }
   
}
