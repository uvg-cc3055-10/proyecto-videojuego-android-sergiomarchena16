using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser1 : MonoBehaviour {

	float lifeTime=2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 25 * Time.deltaTime);

		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	}
}
