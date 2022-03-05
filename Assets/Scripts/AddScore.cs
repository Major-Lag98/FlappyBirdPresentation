using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    public AudioClip scoreSound;
    public AudioSource scoreSoundSource;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        SetScore.Score += 1;
        scoreSoundSource.PlayOneShot(scoreSound);
    }
}
