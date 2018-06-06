using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour {

	private	PlayerMovement character;


	void Start(){
		character = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();


	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Player")) 
		{
			Destroy (this.gameObject);
			PointsController.coinCollection += 1;
		}

	}

}
