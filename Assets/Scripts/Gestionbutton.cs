using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gestionbutton : MonoBehaviour
{

    public int sceneNumber;
    private static int previousScene;
    private int oldPreviousScene;
     ///////////////////////////////////////
     string PrevScene;
     int NextScene ;
    public void Start() {
        PrevScene = PlayerPrefs.GetString("SceneNumber");
        NextScene = PlayerPrefs.GetInt("NextSceneNumber");

        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);  
        PlayerPrefs.SetInt("NextSceneNumber", SceneManager.GetActiveScene().buildIndex +1);  

    }
    public void GoToPrevScene() {
        SceneManager.LoadScene(PrevScene);
        Debug.Log(PrevScene); 
    }
    ///////////////////////////////////////////
     public void GoToNextScene() {
         
        SceneManager.LoadScene(NextScene);
        Debug.Log(NextScene); 

    } /**
    public Text Txt;

    public void Relancement_jeuxsoleil1()
    {
        SceneManager.LoadScene(14);
    }

    public void Relancement_jeuxmars()
    {
        SceneManager.LoadScene(2);
    }
    /// <summary>
    
    /// </summary>
    public void Relancement_jeuxJupiter11()
    {
        SceneManager.LoadScene(4);
    }
    public void Relancement_jeuxSoleil()
    {
        SceneManager.LoadScene(14);
    }
    /// <summary>
    /// //////
    /// </summary>
    public void Relancement_jeuxTerre()
    {
        SceneManager.LoadScene(6);
    }
    public void Relancement_jeuxJupiterRes()
    {
        SceneManager.LoadScene(4);
     }
    //////


    public void Relancement_jeuxNeptune()
    {
        SceneManager.LoadScene(11);
    }
    public void Relancement_jeuxterreRES()
    {
        SceneManager.LoadScene(6);
    }
    /////////
    ///////
    public void Relancement_jeuxSaturne()
    {
        SceneManager.LoadScene(13);
    }
    public void Relancement_jeuxNeptuneES()
    {
        SceneManager.LoadScene(11);
    }
    ////////////
    ///
    public void Relancement_jeuxVenus()
    {
        SceneManager.LoadScene(8);
    }
    public void Relancement_jeuxSaturneRES()
    {
        SceneManager.LoadScene(13);
        
    }
    /////////////////////
    public void Relancement_jeuxuranus()
    {
        SceneManager.LoadScene(10);
    }
    public void Relancement_jeuxVenusRES()
    {
        SceneManager.LoadScene(8);

    }
    /////////////
    ///////////
    public void Relancement_jeuxPluto()
    {
        SceneManager.LoadScene(12);
    }
    public void Relancement_jeuxuranusRES()
    {
        SceneManager.LoadScene(10);

    }
   
    //public void Relancement_jeuxPlutorES()
   // {
        //SceneManager.LoadScene(12);
    //} */
}