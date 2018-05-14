using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarControlActive : MonoBehaviour {

	public GameObject CarControl;

		void Start () { // This sets the car controlsactive after the countdown is over.
		CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;

		}

	}
