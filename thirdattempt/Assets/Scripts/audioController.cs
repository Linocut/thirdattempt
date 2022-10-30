using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioClip musicClipThree;
    public AudioClip musicClipFour;
    public AudioClip musicClipFive;
    public AudioClip musicClipSix;
    public AudioClip musicClipSeven;
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
        musicSource.PlayDelayed(musicClipThree.length);
    }
    public void doorbreak()
    {
        musicSource.clip = musicClipThree;
        musicSource.Play();
    }
    public void owl()
    {
        musicSource.volume = 0.2f;
        musicSource.clip = musicClipFour;
        musicSource.Play();

    }
    public void wind()
    {
        musicSource.volume = 0.1f;
        musicSource.clip = musicClipFive;
        musicSource.Play();
    }
    public void bird()
    {
        musicSource.volume = 0.2f;
        musicSource.clip = musicClipSix;
        musicSource.Play();
    }
    public void glassBreak()
    {
        musicSource.clip = musicClipSeven;
        musicSource.Play();
    }


}
