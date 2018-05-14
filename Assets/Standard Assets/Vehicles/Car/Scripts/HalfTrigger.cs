using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig; //Trigger for the player to pass through
	public GameObject HalfLapTrig; //Trigger for the player to pass through

	void OnTriggerEnter () {
		LapCompleteTrig.SetActive (true); // Sets the Finish trigger to active
		HalfLapTrig.SetActive (false); // Set the half way trigger to false so its not being used

	}
}
