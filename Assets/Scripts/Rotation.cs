using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{   private Rigidbody2D r;
    public int maxHealth = 10;
    public int currentHealth;
    private float rotZ;
    public float rotationspeed;
    private bool clockwiserotation;
    public Rigidbody2D Comet;
    // Start is called before the first frame update
    void start() 
    {
     r = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (clockwiserotation == false)
        {
            rotZ += Time.deltaTime * rotationspeed;
        }
        else
        {
            rotZ += -Time.deltaTime * rotationspeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        // Création dynamique des clones 
       /* if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(Comet, new Vector3(NewSpaceShip.position.x,NewSpaceShip.position.y,2),NewSpaceShip.rotation);
        **/
    void OnCollisionEnter2D(Collision2D Obj)
    {
        if (Obj.gameObject.tag == "fire")
        {// health update
      print("Touché cartouche");
        takeDamage(1);
         if (currentHealth == 0)
           {Destroy(Obj.gameObject);} }
    }
    void OnCollisionExit2D(Collision2D Obj)
    {
        if (Obj.gameObject.tag == "fire")
            print("Touché cartouche");
    }
    void takeDamage(int damage)
    {
        currentHealth -= damage;

       
    }
    }
}
