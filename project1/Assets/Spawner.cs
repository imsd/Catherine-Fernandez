﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


	// add a gameobject to the inspector
	// that we can access in this script
	public GameObject go;

	// start spawning after... seconds
	public float StartAfter = 1f;

	// how often to spawn objects?
	public float SpawnFrequency = .5f;

	// Use this for initialization
	void Start () {

		GameObject NewObject = Instantiate (go, transform.position, Quaternion.identity);
		NewObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 500);

		// print the location of the spawner object
		Debug.Log(transform.position);
		// repeat a function
		// 1: what you want to repeat (as a function)
		// 2: after how many seconds do you want to start doing it?
		// 3: repeat every X seconds
		//InvokeRepeating("SpawnThing", StartAfter, SpawnFrequency);
	}

	// Update is called once per frame
	void SpawnThing () {

		// first, move the spawner
		//		transform.position = new Vector3(Random.Range(-5f,5f), 3, Random.Range(-5f,5f));

		// to create an object, first use Instantiate function
		// which wants 3 arguments:
		// 1: the object you will create
		// 2: WHERE to create that object
		// 3: at what rotation
		GameObject NewObject = Instantiate (go, transform.position, Quaternion.identity);
		NewObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 500);

		// print the location of the spawner object
		Debug.Log(transform.position);
	}
}