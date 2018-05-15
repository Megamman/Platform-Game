using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public int playerSpeed = 10;
	public bool facingRight = true;
	public int playerJumpPower = 1250;
	public float moveX;


	
	// Update is called once per frame
	void Update () {
		
		PlayerMove ();
	}

	void PlayerMove(){

		//controls
		moveX = Input.GetAxis("Horizontal");

		//player Direction
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer ();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer ();

		}

		//physics

		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveX = playerSpeed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);


	}

	void Jump(){

	}

	void FlipPlayer(){
		
	}

}
