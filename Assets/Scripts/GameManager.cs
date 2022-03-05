using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public AudioClip deathSound;
    public AudioSource deathSoundSource;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        deathSoundSource.PlayOneShot(deathSound);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
