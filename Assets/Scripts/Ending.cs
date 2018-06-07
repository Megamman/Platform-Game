using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {

	public GameObject target;
	private PlayerMovement player;


	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();

	}


	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Player")) {
			target.SetActive (true);
			Time.timeScale = 0;
		} else {
			target.SetActive (false);
		}
	}
}
