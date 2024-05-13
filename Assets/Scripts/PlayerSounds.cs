using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnEnable()
    {
        PlayerEvents.OnPlayerHit += PlaySound;
    }

    private void OnDisable()
    {
        PlayerEvents.OnPlayerHit -= PlaySound;
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
    
}
