using UnityEngine;
using System.Collections;

public class axis : MonoBehaviour {
	Rigidbody2D r;

	float speed = 5;
	// Use this for initialization



	void Start () {
		r = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float MoveVertical = Input.GetAxis ("Vertical");
		float MoveHorizontal = Input.GetAxis ("Horizontal");


		Vector2 MovePerso = new Vector2 (MoveHorizontal, MoveVertical);
		r.AddForce (MovePerso * speed);
		r.velocity = MovePerso * speed;
	}
}
