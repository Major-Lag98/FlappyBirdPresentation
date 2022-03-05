using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollionDetection : MonoBehaviour
{

    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D col)
    {
        gameManager.GameOver();
    }
}
