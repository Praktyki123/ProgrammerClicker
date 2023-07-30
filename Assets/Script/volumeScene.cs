using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class volumeScene : MonoBehaviour
{
    public AudioSource VolumeMusic;
  

    void Start()
    {
        VolumeMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
     
    }

    void Update()
    {
        
    }
}
