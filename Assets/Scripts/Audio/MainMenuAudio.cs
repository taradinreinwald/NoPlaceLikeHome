using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuAudio : MonoBehaviour
{
    public Image soundimage;
    public Sprite muted;
    public Sprite unmuted;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Play the audio on start
    }
    public void ToggleMute()
    {
        if (audioSource.mute == true)
        {
            soundimage.sprite = unmuted;
        }
        else if (audioSource.mute == false)
        {
            soundimage.sprite = muted;
        }  
        audioSource.mute = !audioSource.mute;
    }
    
} 
