using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpanner : MonoBehaviour
{  
      
    
    public enum SpawnState {SPANNING, WAITING, COUNTING};
     [System.Serializable] // This allow us to change the values in Unity
    public class Wave
    {
   public Rigidbody2D Soleil;
     public Transform soleilfils;
    public Rigidbody2D Clone ;
          public string name; 
      public Transform enemy;
      public int count;
      public float rate;
    }
    public Wave[] waves;
    private int nextWave =0;

    public Transform[] spawnPoints;
    
    public float timeBetweenWaves = 5f;
    public float waveCountDown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        if (spawnPoints.Length ==0)
          {
              Debug.Log("Erreur, no spawnPoint referenced");
          }
        waveCountDown = timeBetweenWaves;
         
    }
    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            //check if enemies are still alive
            if ( !EnemyIsAlive() ){
                //Begin a new round
                WaveCompleted();
                 
                return;

            }
            else 
            {
                return;
            }
        }
        if ( waveCountDown <= 0 ) 
        {
           if ( state != SpawnState.SPANNING)
           {
               // Start spanning wave
               StartCoroutine(SpanWave (waves[nextWave]));
           }
        }
           else 
           {
               
               waveCountDown -= Time.deltaTime;
           }

           
        }
        void WaveCompleted() 
        {
            Debug.Log("Wave completed");
            state = SpawnState.COUNTING;
            waveCountDown = timeBetweenWaves;
          

            if (nextWave +1 > waves.Length -1)
            {
                nextWave =0; 
                Debug.Log("All wabes comple !, now looping");
            }
            nextWave++;
        }
        bool EnemyIsAlive()
        {
            searchCountdown -= Time.deltaTime;
            if (searchCountdown <=0f)
            {
                searchCountdown = 1f;
                if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
            }
            return true;
        }
        IEnumerator SpanWave(Wave _wave)
        {
            Debug.Log("Span wave");
            state = SpawnState.SPANNING;
            
            // Span 
            for (int i=0; i< _wave.count; i++) 
            {

               SpanEnemy(_wave.enemy);
               //NEWWWWWW *******
           if (Input.GetKey(KeyCode.Mouse0))
           { //Instantiate(Soleil, new Vector3(soleilfils.position.x,soleilfils.position.y,2),soleilfils.rotation);
           
            Clone = Instantiate ( Soleil, new Vector3 (soleilfils.position.x, soleilfils.position.y,2), soleilfils.rotation);
            Clone.AddForce( new Vector3(3000,0,0)); 
            Destroy(Clone.gameObject, 10);
             }
                        
            yield return new WaitForSeconds(1f/_wave.rate);
            }
            state= SpawnState.WAITING;
            yield break;
        }
        void SpanEnemy (Transform _enemy)
        {
          // span enemy
          Debug.Log("Spanning enemy" +_enemy.name);
          if (spawnPoints.Length ==0)
          {
              Debug.Log("Erreur, no spawnPoint referenced");
          }
          Transform _sp = spawnPoints[Random.Range (0, spawnPoints.Length)];
          Instantiate(_enemy, _sp.position, _sp.rotation);
        }   
         



}
