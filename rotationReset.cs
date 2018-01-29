using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationReset : MonoBehaviour {

	void Update() {
		
		if(Input.GetButtonDown("Fire1")) // 실행조건
			transform.localRotation = Quaternion.identity; // 월드 or 부모 좌표에 정렬

	}

}
