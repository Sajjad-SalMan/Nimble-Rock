using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private Toggle sfxToggle;

    private void Start()
    {
        LoadMute();
        LoadSFXMute();
    }
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
            musicToggle.isOn = true;
        }
        else
        {
            musicToggle.isOn = false;
        }
    }

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
            sfxToggle.isOn = true;
        }
        else
        {
            sfxToggle.isOn = false;
        }
    }
}
