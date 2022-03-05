using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public static int Score;
    
    public Text scoreText;

    private void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // ever frame update text to reflect our score
        scoreText.text = Score.ToString();
    }
}
