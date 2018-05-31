using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour {

	public Transform[] points;
	int target = 0;

	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, points [target].position, 2f * Time.deltaTime);
		if (transform.position.Equals (points [target].position)) {
			target = (target + 1) % points.Length;
		}

	}
}
