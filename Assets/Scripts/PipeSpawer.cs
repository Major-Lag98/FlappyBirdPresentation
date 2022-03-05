using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawer : MonoBehaviour
{
    private float _timer;

    public float maxTime; // seconds to spawn pipe 

    public GameObject pipeHolder;

    public float timeToDespawn;

    public float heightRange;
    

    // Update is called once per frame
    void Update()
    {
        // every x seconds 
        if (_timer >= maxTime)
        {
            // spawn a pipe
            GameObject newPipes = Instantiate(pipeHolder);

            newPipes.transform.position =
                this.transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
            
            // after y seconds de-spawn pipe.
            Destroy(newPipes, timeToDespawn);
            
            _timer = 0;
        }
        
        
        // add time to timer
        _timer += Time.deltaTime;
    }
}
