using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{    
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update(){
   /* { if (Input.GetKeyDown(KeyCode.Space))
    {
        loadNextLevel();
    }**/
        
    }
    public void loadNextLevel ()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    // Cette fct empeche la transition directe des scenes et donne le temps pour l'animation
    IEnumerator LoadLevel(int levelIndex)
    {  // Pour lancer l'animation
       transition.SetTrigger("play");
       // Attendre jusqu'à l'animation se termine 
       yield return new WaitForSeconds(transitionTime);
       // Charger la scene suivante 
       SceneManager.LoadScene(levelIndex);
    }
}
