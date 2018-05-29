using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	private	PlayerMovement character;

	void Start(){

		character = gameObject.GetComponentInParent<PlayerMovement> ();

	}

	void Update()
	{
		//character.grounded = Physics2D.Linecast(transform.position, transform
	}

}
