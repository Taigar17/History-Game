using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    //Sound Code
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume); 
        //Uses AudioMixer to adjust volume
        //Check by opening AudioMixer Window
    }

    //Graphics Dropdown Code
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        //To check Edit<Project Settings<Quality run and see change
        //Change is slow but works
    
    }
}