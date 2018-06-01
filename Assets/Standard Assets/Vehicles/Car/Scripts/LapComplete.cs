/* Magnus Crooke
 * 6-1-18
 * This code is responsible for displaying the lap time to the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig; //Triggers
	public GameObject HalfLapTrig; //Triggers

	//Lap time display
	public GameObject MinuteDisplay; 
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	void OnTriggerEnter () {
		//The lap time is being recorded on screen
		if (LapTimeManager.SecondCount <= 9) { //Seconds count
			SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
		} else {
			SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
		}

		if (LapTimeManager.MinuteCount <= 9) { //Minute count
			MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
		} else {
			MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
		}

		MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount; //millisecond count
		//Saving the last lap time
		PlayerPrefs.SetInt ("MinSave", LapTimeManager.MinuteCount);
		PlayerPrefs.SetInt ("SecSave", LapTimeManager.SecondCount);
		PlayerPrefs.SetInt ("MinSave", LapTimeManager.SecondCount);
		//resets the lap counter
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;

		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}
}