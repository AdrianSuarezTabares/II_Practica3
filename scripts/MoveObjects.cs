using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour {
	public Vector3 offset;

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			moveObject();
		}
	}

	void moveObject() {
		Vector3 newPos = transform.position + offset;
		transform.position = newPos;
		Debug.Log($"Objeto movido a la nueva posición: {newPos}");
	}
}
