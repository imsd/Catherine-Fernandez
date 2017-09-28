using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOnClick : MonoBehaviour {

	// keep track of whether or not the object is active
	bool isActive = false;

	// the renderer for this object
	public Renderer rend;

	// Use this for initialization
	void Start () {
		// at start, get the Renderer component of this object
		rend = GetComponent<Renderer> ();
	}

	void Update () {
		if (isActive) {
			// shake randomly within .1 unit
			Vector3 randomShake = Random.insideUnitSphere * .1f;
			transform.position += randomShake;
		}
	}

	void OnMouseDown() {
		// invert the value
		isActive = !isActive;

		// set color based on change
		if (isActive) {
			rend.material.color = Color.red;
		} else {
			rend.material.color = Color.white;
		}
	}
}