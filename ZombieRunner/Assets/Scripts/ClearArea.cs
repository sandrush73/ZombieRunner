using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	private bool foundClearArea = false ;


	// Update is called once per frame
	void Update () {

		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 2f && Time.realtimeSinceStartup > 15f && !foundClearArea) {
		
			SendMessageUpwards ("OnFindClearArea");  /// used to call function 
			foundClearArea = true;
			 
		}
	}

	void OnTriggerStay (Collider coll) {

		if (coll.gameObject.name != "Player") {
		
			timeSinceLastTrigger = 0f;
		}

	}
}
