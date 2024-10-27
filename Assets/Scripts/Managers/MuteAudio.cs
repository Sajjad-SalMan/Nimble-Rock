using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private TMP_Text musicValueText;
    [SerializeField] private AudioSource music;

    private float musicValueBeforeMute;
    private void Awake()
    {
        LoadMusicValue();
    }

    private void Update()
    {
        SetMusicValue();
        LoadMusicValue();
    }

    private void SetMusicValue()
    {
        float musicValue = musicSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", musicValue / 10);
    }

    private void LoadMusicValue()
    {
        float musicValue = PlayerPrefs.GetFloat("MusicVolume", 0.7f);
        musicSlider.value = musicValue * 10;
        music.volume = musicValue;
        musicValueText.text = musicValue.ToString("0.0");
    }

    public void musicMute(bool mute)
    {
        if (mute)
        {
            musicSlider.value = 0;
            musicValueBeforeMute = PlayerPrefs.GetFloat("MusicVolume");
            Debug.Log(musicValueBeforeMute);
        }
        if(!mute)
        {
            musicSlider.value = .7f;
        }
    }
}
