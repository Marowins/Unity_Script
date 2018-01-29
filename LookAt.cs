using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	Transform obj = null;

	void Start(){
		// find
		obj = GameObject.Find("Cube2").transform;
	}

	void Update(){

		// 죤나 꿀잼, 점프해도 한 옵젝만 바라봄, 석상 눈동자에 사용 가능할듯
		transform.LookAt (obj);
	}

}
