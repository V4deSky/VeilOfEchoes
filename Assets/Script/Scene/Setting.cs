using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    private MusicScript Music;
    [SerializeField]private Slider slider;
    private void Awake()
    {
        Music = FindAnyObjectByType<MusicScript>();
        if(Music != null && slider != null)
        {
            slider.onValueChanged.AddListener(Music.Volume);
            slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        }
        else
        {
            Debug.LogWarning("MusicScript или Slider не найдены!");
        }
    }
}
