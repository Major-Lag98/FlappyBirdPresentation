using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;

    public float velocityMultiplier;

    public AudioClip jumpSound;

    public AudioSource jumpAudioSource;

    // Update is called once per frame
    void Update()
    {
        //check if the player is pressing space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump
            birdRigidbody.velocity = new Vector2(0, 1) * velocityMultiplier;
            jumpAudioSource.PlayOneShot(jumpSound);
            
        }
            
    }
}
