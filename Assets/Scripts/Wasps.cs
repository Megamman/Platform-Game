using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasps : MonoBehaviour {

	private PlayerMovement player;

	void Start(){

		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();

	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Player")) {
			if (player.grounded) {
				player.Damage (1);
				player.Knockback ();
			} else {
				Destroy (this.gameObject);
			}

		}


	}
}
