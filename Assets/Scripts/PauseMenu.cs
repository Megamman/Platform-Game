using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;


	private bool paused = false;

	void Start()
	{

		PauseUI.SetActive (false);
	}

	void Update()
	{

		if (Input.GetButtonDown ("Pause")) {

			paused = !paused;
			PauseUI.SetActive (paused);
			Time.timeScale = paused ? 0f : 1f;
		}

	}

	public void Resume(){

		paused = false;
	}

	public void Restart(){

		Application.LoadLevel (Application.loadedLevel);
		
	}

	public void Quit(){

		Application.Quit ();
	}




}
