/* Magnus Crooke
 * 6-1-18
 * This code is responsible for loadig in the second map
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramp : MonoBehaviour {

	public GameObject nextmap;
	//loads a second map
	private Vector3 mapposi = new Vector3 (-500, -10, 0);

	void OnTriggerEnter (Collider other){

		if (other.tag == "Player") {
			Instantiate (nextmap, mapposi, Quaternion.identity);
		}
	}
}
