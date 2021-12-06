using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMana : MonoBehaviour
{
    public AudioClip[] playlist = new AudioClip[0];
    public AudioSource audioSource;
    private int musicIndex = 0;

    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextSong();
        }
    }

    void PlayNextSong()
    {
        musicIndex = (musicIndex + 1) % playlist.Length;
        audioSource.clip = playlist[musicIndex];
        audioSource.Play();
    }
}
