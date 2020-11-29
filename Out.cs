using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Out : MonoBehaviour {
	
	public static bool goal;

	void Start() {
		goal = false;
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			goal = true;
		}
	}
}
