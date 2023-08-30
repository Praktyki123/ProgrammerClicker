using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class volumeScene : MonoBehaviour
{
    public AudioSource VolumeMusic;
  

    void Start()
    {
        VolumeMusic.time = PlayerPrefs.GetFloat("AudioTime");
    }

    void Update()
    {

            VolumeMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
            PlayerPrefs.SetFloat("AudioTime", VolumeMusic.time);
    }
}
