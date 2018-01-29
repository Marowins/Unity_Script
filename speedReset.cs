using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedReset : MonoBehaviour {

	void Update () {
		if(Input.GetButtonDown("Fire1")) // 실행조건
			GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
			// 현재 속력을 0으로 바꾸는 행위, AddForce종간에 멈추는게 가능
			//	그러나 유니티 메뉴얼에서는 velocity값을 직젒수정하면 현실적이지 않다고 고치지 말걸 권유
	}
}
