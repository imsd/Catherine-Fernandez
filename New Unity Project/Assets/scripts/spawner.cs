using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject go;
	public float StartAfter = 1f;

	public float SpawnFrequency = .5f;

	//Start spawning after ...seconds
	// Use this for initialization
	void Start () {
		// 1: what you want to repeat as a function
		//2: How many seconds do you want to start doing it?
		// 3: repeat every x seconds
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
		
	}
	
	// Update is called once per frame
	void SpawnThing () {

		transform.position = new Vector3(Random.Range(-5,5), 3, Random.Range(-5,5));

		Instantiate (go, transform.position, Quaternion.identity);


		// print the log of spawner object
		Debug.Log(transform.position);
		
	}
}
