using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAudio : MonoBehaviour
{

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Play the audio on start
    }

    public void ToggleMute()
    {
        audioSource.mute = !audioSource.mute; // Toggle mute state
    }
}
