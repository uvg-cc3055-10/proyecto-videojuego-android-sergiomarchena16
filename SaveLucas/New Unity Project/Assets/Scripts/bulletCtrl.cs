using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCtrl : MonoBehaviour {

	public Vector2 speed;
	Rigidbody2D rb;
	float lifeTime=3;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = speed;
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = speed;
		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	}
}
