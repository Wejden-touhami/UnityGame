using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneVenus : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Venus"))
        {
            SceneManager.LoadScene(7);
        }
        //else
        // other.CompareTag ("Neptune");
        //{
        // SceneManager.LoadScene(7);


        // }
        //}

    }
}
