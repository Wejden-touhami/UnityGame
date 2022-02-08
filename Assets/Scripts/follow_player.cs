using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
 public Transform spaceship; 
 public Vector3 offset;  

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(spaceship.position);
       transform.position = spaceship.position + offset;
    }
}
