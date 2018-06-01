/* Magnus Crooke
 * 6-1-18
 * This code is responsible for restarting the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	//restarts the level/game
	public void StartGame() {
		SceneManager.LoadScene ("Final Project"); 
	}
}
