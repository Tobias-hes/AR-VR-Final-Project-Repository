using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsGameManager : MonoBehaviour
{
    public AudioClip moveSound;
    public AudioClip selectSound;

    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    public void PlayMoveSound()
    {
        sound.PlayOneShot(moveSound);
    }
    public void PlaySelectSound()
    {
        sound.PlayOneShot(selectSound);
    }
    public void PlayASound(AudioClip clip)
    {
        sound.PlayOneShot(clip);
    }

  
}
