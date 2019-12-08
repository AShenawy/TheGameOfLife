using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script is used for buttons to play sound through the SoundManager script
public class UISoundPlayer : MonoBehaviour
{
    [SerializeField]public SoundManager soundMan;

    public void PlaySound(AudioClip audio)
    {
        soundMan.PlaySFX(audio);
    }
}
