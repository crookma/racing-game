/* Magnus Crooke
 * 6-1-18
 * This code is responsible for setting the car controls on when the countdown is done.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarControlActive : MonoBehaviour {

	public GameObject CarControl;

		void Start () { // This sets the car controlsactive after the countdown is over.
		CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;

		}

	}
