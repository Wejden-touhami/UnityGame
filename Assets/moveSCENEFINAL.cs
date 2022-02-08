using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveSCENEFINAL : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PLUTO"))
        {
            SceneManager.LoadScene(9);
        }
        //else
        // other.CompareTag ("Neptune");
        //{
        // SceneManager.LoadScene(7);


        // }
        //}

    }
}
