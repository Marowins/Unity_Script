using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	Transform obj = null;

	void Start() {
		// find
		obj = GameObject.Find("Cube2").transform;
	}

	void Update(){
		transform.RotateAround (obj.position, Vector3.up, 40 * Time.deltaTime);
		transform.LookAt (obj);
	}
}
