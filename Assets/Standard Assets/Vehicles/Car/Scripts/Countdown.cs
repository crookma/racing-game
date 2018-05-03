using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject CarControls;

	void Start () { //Starts the countdown
			StartCoroutine (CountStart ());		
	}
		

	IEnumerator CountStart () { //The countdown inthe beginning of the race
		LapTimer.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		CountDown.GetComponent<Text> ().text = "3"; //The #3 will appear on screen
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		CountDown.GetComponent<Text> ().text = "2"; //The #2 will appear on screen
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		CountDown.GetComponent<Text> ().text = "1"; //The #1will appear on screen
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		GoAudio.Play (); 
		LapTimer.SetActive (true);
		CarControls.SetActive (true);

	}


}
	