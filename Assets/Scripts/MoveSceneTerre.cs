using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneTerre : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Terre"))
        {
            SceneManager.LoadScene(6);
        }
        //else
        // other.CompareTag ("Neptune");
        //{
        // SceneManager.LoadScene(7);


        // }
        //}

    }
}
