using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	// Use this for initialization

	public AudioClip initialHeliClip;
	public AudioClip initialCallReply;

	private AudioSource audioSource;

	void Start () {

		audioSource = GetComponent<AudioSource> ();

	}

	void OnMakeInitialheliCall () {

		print (name + "OnMakeInitialHeliCall");
		audioSource.clip = initialHeliClip;
		audioSource.Play ();

		Invoke ("InitialReply", initialHeliClip.length + 1f);


	}

	void InitialReply() {


		audioSource.clip = initialCallReply;
		audioSource.Play ();

		BroadcastMessage ("OnDispatchHeli", initialCallReply.length + 1f);

	}
}


