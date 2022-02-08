using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aleatoire : MonoBehaviour
{
        public Rigidbody2D Comet;

    // Start is called before the first frame update
    void Start()
    {  for (int i = 0; i < 3; i++) {
       Vector3 PositionComet = new Vector3 (Random.Range (-5*(i*10),5+i), Random.Range(-5-(i*10),5),1); 
      Comet = Instantiate (Comet, PositionComet, Quaternion.identity) as Rigidbody2D;
      print(PositionComet); 
      print("Génération automatique"); 
      Vector3 PositionComet2 = new Vector3 (Random.Range (-2*(i*10),2+i), Random.Range(-2-(i*10),2),1); 
      Comet = Instantiate (Comet, PositionComet2, Quaternion.identity) as Rigidbody2D;
      print("Génération automatique 2  1"); 

      //Destroy(Obj.gameObject);
      float lifetime = 3.0f;
 
     Destroy (Comet, lifetime); 
    }
    }

   
}
