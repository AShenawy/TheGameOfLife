using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script stores links to audio sources and also plays the sound effects
public class SoundManager : MonoBehaviour
{
    public AudioSource bGMSource;
    public AudioSource sFXSource;

    void Start()
    {
        // Make sure background music source is active to play music
        bGMSource.gameObject.SetActive(true);
    }

    // To be used by other sound playing scripts
    public void PlaySFX(AudioClip sfx)
    {
        sFXSource.PlayOneShot(sfx);
    }

}
