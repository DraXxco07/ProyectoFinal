using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUDIO : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void PlayButtonSound()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
