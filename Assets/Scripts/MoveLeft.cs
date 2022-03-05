using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        // take our current position and move it a little to the left
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
