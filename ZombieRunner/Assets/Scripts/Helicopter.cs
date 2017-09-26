using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public bool calledHelo = false;


	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {

		rigidBody = GetComponent<Rigidbody> ();

	}

	public void OnDispatchHeli () {
		calledHelo = true;
		rigidBody.velocity = new Vector3 (0, 0, 50f);

	}

}
