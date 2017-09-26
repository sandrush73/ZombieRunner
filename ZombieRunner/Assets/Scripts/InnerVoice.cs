using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappned;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {

		audioSource = GetComponent <AudioSource> ();
		audioSource.clip = whatHappned;
		audioSource.Play ();

	}


	void OnFindClearArea() {

		print (name + "OnFindClearArea");
		audioSource.clip = goodLandingArea;
		audioSource.Play ();

	
		Invoke ("CallHeli", goodLandingArea.length + 1);

	}

	void CallHeli () {
	
		SendMessageUpwards ("OnMakeInitialHeliCall");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
