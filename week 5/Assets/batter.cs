using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batter : MonoBehaviour {

	public float rotatePower;

	// Update is called once per frame
	void Update () {
		//		float rot = Input.mousePosition.x;

		transform.Rotate (new Vector3(-1,0,0) * rotatePower);
	}
}