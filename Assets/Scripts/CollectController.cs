using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Collecting/Destroying Objects Script
public class CollectController : MonoBehaviour {

	void Start () {

	}

	// This function will trigger as soon as the player touches a ball.
	// This function requires a parameter to be a collider
	// Collider C is whatever the Capsule(player) will have touched.
	void OnTriggerEnter(Collider c) {
		
		// If the Game Object attached to the collider is a ball, it gets destroyed.
		if (c.gameObject.tag == "coin") {

			Destroy (c.gameObject);

			// This comand will add +1 to the Score Counter
			PointsController.scoreValue += 1;

			// this amkes the object destroyed
			Destroy (c.gameObject);

			// 	AudioSource source = GetComponent<AudioSource> ();
			// 	source.Play ();

		}

	}
}
