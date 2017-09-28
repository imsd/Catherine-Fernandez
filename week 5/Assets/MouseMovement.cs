using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour {

	void Update () {
		// the mouse position returns a pixel coordinate, so if your mouse is
		// in the top left corner it's 0,0 and if it's in the middle of the screen
		// it's something like 600,400 (depending on window size).
		// but if we want to move objects around this isn't very helpful, since moving
		// something 1 unit in unity is a perceptible change and moving it 600 units
		// is waaaayyy far away, so we need to get the mouse position as a ratio:
		float normalizedMouseX = Input.mousePosition.x / Screen.width;

		// now normalizedMouseX returns a value between 0 and 1, but if we want center screen
		// to be 0, or no movement, we need to offset by -.5

		normalizedMouseX -= .5f;

		Debug.Log (normalizedMouseX);

		// now do the same for Y
		float normalizedMouseY = Input.mousePosition.y / Screen.height;
		normalizedMouseY -= .5f;

		// and finally, move the object
		transform.position += new Vector3 (normalizedMouseX, 0, normalizedMouseY);
	}
}
