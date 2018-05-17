using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 10f;
	public float jumpSpeed = 5f;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		//press a - move left
		if(Input.GetKey(KeyCode.A)){
			rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);
		}
		//press d - move right

		if(Input.GetKey(KeyCode.D)){
			rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
		}


		//remove a - stop moving left

		if(Input.GetKeyUp(KeyCode.A)){
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
		//remove d - stop moving right

		if(Input.GetKeyUp(KeyCode.D)){
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		//jump
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpSpeed);
		}


		
	}
}
