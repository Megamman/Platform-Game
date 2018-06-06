using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour {

	Animator anim;
	public GameObject target;
	private PlayerMovement player;


	void Awake()
	{
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();

	}


	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Player")) {
			if(tag == "firstLever"){
				target.SetActive (false);
				anim.SetTrigger ("pull");
			}

			if(tag == "SecondLever"){
				target.SetActive (true);
				anim.SetTrigger ("pull");
			}




		}


	}

}
