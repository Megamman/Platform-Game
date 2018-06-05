using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsController : MonoBehaviour {


	public static int scoreValue = 0;

	
	Text score; 

	public static int coinAmount;

	// Use this for initialization
	void Start () {

		score = GetComponent <Text> ();

	}
	

}
