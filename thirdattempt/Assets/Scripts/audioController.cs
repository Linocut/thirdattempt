using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioClip musicClipThree;
    public AudioSource musicSource;

    // Update is called once per frame
    public void knocking()
    {
        musicSource.clip = musicClipOne;
        musicSource.Play();
    }
    public void footsteps()
    {
        musicSource.clip = musicClipTwo;
        musicSource.Play();
    }
    public void doorbreak()
    {
        musicSource.clip = musicClipThree;
        musicSource.Play();
    }

       
}
