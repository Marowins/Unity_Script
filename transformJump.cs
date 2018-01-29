using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformJump : MonoBehaviour {

	float gravity = 0.0f;
	Vector3 velocity;

	void Start() {
		velocity = transform.position;
	}

	void Update() {
		if(Input.GetButtonDown("Jump"))
			gravity = 10.0f;

		velocity.y += gravity * Time.deltaTime;
		transform.position = velocity;

		gravity -= 0.5f;

		if (velocity.y < 0.5f) {
			velocity.y = 0.5f;
			gravity = 0.0f;
		}
		
	}

}
