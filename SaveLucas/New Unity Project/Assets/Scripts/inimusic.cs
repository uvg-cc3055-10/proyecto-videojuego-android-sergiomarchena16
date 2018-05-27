using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimusic : MonoBehaviour {
	AudioSource aux;

	// Use this for initialization
	void Start () {
		aux = GetComponent<AudioSource>();
		aux.Play();
		
	}

}
