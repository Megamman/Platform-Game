using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsController : MonoBehaviour {


	public static int coinCollection = 0;

	
	Text score; 

	public static int coinAmount;

	// Use this for initialization
	void Start () {

		score = GetComponent <Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		// How the text will show as score
		score.text = "x" + coinCollection;

	}
}
