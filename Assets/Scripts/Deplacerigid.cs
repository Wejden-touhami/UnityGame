using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deplacerigid : MonoBehaviour
{
    private Rigidbody2D r;
    float speed = 80;
    public int maxHealth = 3;
    public int currentHealth;
    public Healthbar healthBar;
    public Rigidbody2D Soleil;
    public Transform soleilfils;
    public Rigidbody2D Clone ;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        // Enregistrer l'index de la scéne actuelle
        // Scene number pour le bouton réssayer
         PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);
         // NextSceneNumber pour le bouton suivant
         PlayerPrefs.SetInt("NextSceneNumber", SceneManager.GetActiveScene().buildIndex +1);  

         ///////////////////////////////////////////////////////////////////////////
    }

    // Update is called once per frame
    void Update()
    {
        float MoveVertical = Input.GetAxis("Vertical");
        float MoveHorizontal = Input.GetAxis("Horizontal");


        Vector2 MovePerso = new Vector2(MoveHorizontal, MoveVertical);
        // r.AddForce(MovePerso * speed);
        r.velocity = MovePerso * speed;

         // shooting guns 
         if (Input.GetKeyDown(KeyCode.Space))
           { //Instantiate(Soleil, new Vector3(soleilfils.position.x,soleilfils.position.y,2),soleilfils.rotation);
            Clone = Instantiate (Soleil, new Vector3 (soleilfils.position.x, soleilfils.position.y,2), soleilfils.rotation);
            Clone.AddForce( new Vector3(3000,0,0)); 
            Destroy(Clone.gameObject, 10); }
    }
    void OnCollisionEnter2D(Collision2D Obj)
    {
         bool damagePlayer = false;
        if (Obj.gameObject.tag == "comet")
            Destroy(Obj.gameObject);
        // health update
        takeDamage(1);
       
            if (currentHealth == 0)
            Application.LoadLevel(13);

        
           
    }
    void OnCollisionExit2D(Collision2D Obj)
    {
        if (Obj.gameObject.tag == "comet")
            {print("spaceship touche astroide");}
        else if (Obj.gameObject.tag == "Enemy")
        {
            print(" Touching Enemy");
        }
    }
    void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);

       print("spaceship touché");
    }
    



}
    
