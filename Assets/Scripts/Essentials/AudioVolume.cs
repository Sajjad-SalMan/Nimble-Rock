using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioVolume : MonoBehaviour
{
    [Header("Music")]
    private AudioSource music;

    [SerializeField] private Slider musicSlider;
    [SerializeField] private TMP_Text musicValueText;
    [SerializeField] private Toggle musicToggle;

    [Header("Sfx")]
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private TMP_Text sfxValueText;
    [SerializeField] private Toggle sfxToggle;

    [Header("Control")]
    [SerializeField] private Toggle defaultCtrlToggle;
    [SerializeField] private Toggle invertedCtrlToggle;

    private void Start()
    {
        music = AudioManager.instance.gameObject.GetComponent<AudioSource>();

        LoadMute();
        LoadSFXMute();

        LoadMusicValue();
        LoadsfxValue();

        LoadCtrl();
    }

    private void Update()
    {
        SetMusicValue();
        LoadMusicValue();

        SetsfxValue();
        LoadsfxValue();
    }

    #region Global Value
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

    private void SetsfxValue()
    {
        float sfxValue = sfxSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxValue / 10);
    }

    private void LoadsfxValue()
    {
        float sfxValue = PlayerPrefs.GetFloat("sfxVolume", 1f);
        sfxSlider.value = sfxValue * 10;
        AudioManager.instance.SFXVolume(sfxValue);
        sfxValueText.text = sfxValue.ToString("0.0");

    }
    #endregion

    #region Music Mute System
    public void musicMute(bool mute)
    {
        if (mute)
        {
            AudioManager.mute = true;
            PlayerPrefs.SetInt("Muted", 1);
        }
        if (!mute)
        {
            AudioManager.mute = false;
            PlayerPrefs.SetInt("Muted", 0);
        }
    }

    private void LoadMute()
    {
        if (PlayerPrefs.GetInt("Muted") == 1)
        {
            AudioManager.mute = true;
            musicToggle.isOn = true;
        }
        else
        {
            AudioManager.mute = false;
            musicToggle.isOn = false;
        }
    }
    #endregion

    #region SFX Mute System
    public void SfxMute(bool mute)
    {
        if (mute)
        {
            AudioManager.sfx_mute = true;
            PlayerPrefs.SetInt("SFXMuted", 1);
        }
        if (!mute)
        {
            AudioManager.sfx_mute = false;
            PlayerPrefs.SetInt("SFXMuted", 0);
        }
    }

    private void LoadSFXMute()
    {
        if (PlayerPrefs.GetInt("SFXMuted") == 1)
        {
            AudioManager.sfx_mute = true;
            sfxToggle.isOn = true;
        }
        else
        {
            AudioManager.sfx_mute = false;
            sfxToggle.isOn = false;
        }
    }
    #endregion

    #region Control

    public void DefaultCtrl(bool On)
    {
        if (On)
        {
            invertedCtrlToggle.isOn = false;
            PlayerPrefs.SetInt("Inverted", 0);
        }
        if (!On)
        {
            invertedCtrlToggle.isOn = true;
            PlayerPrefs.SetInt("Inverted", 1);
        }
    }

    public void InvertedCtrl(bool On)
    {
        if (On)
        {
            defaultCtrlToggle.isOn = false;
            PlayerPrefs.SetInt("Inverted", 1);
        }
        if (!On)
        {
            defaultCtrlToggle.isOn = true;
            PlayerPrefs.SetInt("Inverted", 0);
        }
    }

    private void LoadCtrl()
    {
        if (PlayerPrefs.GetInt("Inverted") == 0)
        {
            defaultCtrlToggle.isOn = true;
            invertedCtrlToggle.isOn = false;
        }
        else
        {
            defaultCtrlToggle.isOn = false;
            invertedCtrlToggle.isOn = true;
        }
    }
    #endregion
}
