using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private AudioSource As;
    private static MusicScript MS;


    private void Awake()
    {
        As = GetComponent<AudioSource>();
        if(MS == null)
        {
            MS = this;
            DontDestroyOnLoad(this.gameObject);
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
            int savedMute = PlayerPrefs.GetInt("MusicMute", 0);
            As.volume = savedVolume;
            As.mute = (savedMute == 1);
            As.Play();
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void Volume(float volume)
    {
        As.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume",volume);
    }
    public void Mute(bool isMute)
    {
        As.mute = isMute;
        PlayerPrefs.SetInt("MusicMute", isMute ? 1 : 0);
    }

}
