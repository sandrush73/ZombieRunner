using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public bool timeToSpawn;

	public Transform playerSpawnPoints;

	private Transform[] spawnPoints;

	private bool lastToggle = false;



	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
		/// other way to use if there are multip;le audiosources
		//		foreach (AudioSource audioSource in audioSources) {
		//			if (audioSource.priority == 1) {
		//				innerVoice = GetComponent<AudioSource> ();
		//			}
		//
		//		}
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

	void OnFindClearArea () {

		Invoke ("DropFlair", 3f);


	}

	void DropFlair () {
	
	
	}
}
