using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramp : MonoBehaviour {

	public GameObject nextmap;

	private Vector3 mapposi = new Vector3 (-500, -10, 0);

	void OnTriggerEnter (Collider other){

		if (other.tag == "Player") {
			Instantiate (nextmap, mapposi, Quaternion.identity);
		}
	}
}
