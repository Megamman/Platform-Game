using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour {



	public Transform[] points;
	int target = 0;

	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, points [target].position, 3f * Time.deltaTime);
		if (transform.position.Equals (points [target].position)) {
			target = (target + 1) % points.Length;
		}
		
	}

	void MoveGround(){





	}
}
