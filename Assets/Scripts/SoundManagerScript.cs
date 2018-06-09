using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {


	public static AudioClip playerHit, playerHurt, coin;

	static AudioSource audioSrc;

	void Start(){

		playerHit = Resources.Load<AudioClip> ("Squish");
		playerHurt = Resources.Load<AudioClip> ("Ouch");
		coin = Resources.Load<AudioClip> ("CoinCollect");
	
		audioSrc = GetComponent<AudioSource> ();
	}

	public static void PlaySound (string clip){

		switch (clip) {
		case "Squish":
			audioSrc.PlayOneShot (playerHit);
			break;
		case "Ouch":
			audioSrc.PlayOneShot (playerHurt);
			break;
		case "CoinCollect":
			audioSrc.PlayOneShot (coin);
			break;

		}
	}
}
