using System.Collections;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] sounds;

    private AudioSource song;
    public static bool mute;
    public static bool sfx_mute;

    private void Awake()
    {
        if( instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.mute = s.mute;
        }

        song = GetComponent<AudioSource>();
    }
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound: " + name + "not found");
            return;
        }
        s.source.Play();
    }

    private void Update()
    {
        musicMute();
        sfxMute();

        foreach (Sound s in sounds)
        {
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.mute = s.mute;
        }
    }

    public void musicMute()
    {
        if (mute)
        {
            song.mute = true;
        }
        else
        {
            song.mute = false;
        }
    }

    public void sfxMute()
    {
        var Sound = GetComponent<AudioManager>().sounds;

        if (sfx_mute)
        {
            foreach (Sound s in Sound)
            {
                s.mute = true;
            }
        }
        else
        {
            foreach (Sound s in Sound)
            {
                s.mute = false;
            }
        }
    }

    public void SFXVolume(float volume)
    {
        foreach (Sound s in sounds)
        {
            s.volume = volume;
        }
    }
}
