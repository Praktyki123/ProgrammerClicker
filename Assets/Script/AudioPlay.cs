using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audioSound;
    public AudioClip clip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playSound()
    {
        audioSound.PlayOneShot(clip);
    }
}
