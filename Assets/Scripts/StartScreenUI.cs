using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenUI : MonoBehaviour {


	public GameObject StartUI;
	private bool gameStart = true;


	void Awake()
	{
		Time.timeScale = 0;

	}

	public void StartGame(){
		Time.timeScale = 1;
	}




}
