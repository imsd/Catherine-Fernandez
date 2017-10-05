using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogspawner : MonoBehaviour {
	public GameObject go; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")) {
			// create a phys sphere when spacebar is hit
			GameObject NewObject = Instantiate (go, transform.position, Quaternion.identity);
			NewObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 500);
			NewObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 150);

		}
	}
}
