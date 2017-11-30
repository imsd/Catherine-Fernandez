using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitcher : MonoBehaviour {

	public GameObject go;


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")) {
			// create a phys sphere when spacebar is hit and call it baseball
			GameObject baseball = Instantiate (go, transform.position, Quaternion.identity);
			// add a force to this newly created baseball
			baseball.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 1200f);

		}

	}
}
