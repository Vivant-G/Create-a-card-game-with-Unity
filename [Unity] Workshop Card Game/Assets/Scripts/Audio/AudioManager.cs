using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Music1");
    }

    public void PlayMusic(string name)
    {
        Sound music = Array.Find(musicSounds, x => x.name == name);

        if (music == null)
            Debug.Log("Can't play music, " + name + " sound not found");
        else
        {
            musicSource.clip = music.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound sfx = Array.Find(sfxSounds, x => x.name == name);

        if (sfx != null)
            sfxSource.PlayOneShot(sfx.clip);
        else
            Debug.Log("Can't play sfx, " + name + " sound not found");
    }

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
