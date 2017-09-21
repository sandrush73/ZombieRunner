using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public bool timeToSpawn;

	public Transform playerSpawnPoints;

	private Transform[] spawnPoints;

	private bool lastToggle;




	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (lastToggle != timeToSpawn) {
			RespanwPlayer ();
			timeToSpawn = false;

		} else {
			lastToggle = timeToSpawn;
		 }
		
	}

	private void RespanwPlayer  () {

		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	
	}
}
