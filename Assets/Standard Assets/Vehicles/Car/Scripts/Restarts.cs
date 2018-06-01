/* Magnus Crooke
 * 6-1-18
 * This code is responsible for restarting the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarts : MonoBehaviour {
	//Restarts the level/game
	public void StartGame() { //Starts the game
		SceneManager.LoadScene ("Final Project"); //Starts the game

	}
	//public void CheckGameOver() {
		//if 
}
