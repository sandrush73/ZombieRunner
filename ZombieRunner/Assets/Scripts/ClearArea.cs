using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 2f) {
		
			Debug.Log ("In a clear area");
			 
		}
	}

	void OnTriggerStay (Collider coll) {

		if (coll.gameObject.name != "Player") {
		
			timeSinceLastTrigger = 0f;
		}
	
//		if (coll == null) {
//		
//		
//			Debug.Log ("no collisisons detected");
//		
//		} else {
//
//			Debug.Log (coll.name);
//			Debug.Log ("collisions Detected");
//
//		}
//	
	}
}
