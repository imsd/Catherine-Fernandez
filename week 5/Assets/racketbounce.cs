using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketbounce : MonoBehaviour {

	void OnCollisionEnter ( Collision coll) {

		coll.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 500);
		coll.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 150);
	}
}
