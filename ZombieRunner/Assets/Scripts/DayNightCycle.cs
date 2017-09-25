using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

	public float dayTimeCycle;
	private Quaternion initialSunRotation;

	// Use this for initialization
	void Start () {

		initialSunRotation = transform.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = Time.deltaTime / 360;

		transform.RotateAround (transform.position, Vector3.forward, angleThisFrame);


	}
}
