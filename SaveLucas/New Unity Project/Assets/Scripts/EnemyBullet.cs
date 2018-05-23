﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float lifeTime = 3;

	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * 3 * Time.deltaTime);
		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	}
}

