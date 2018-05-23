using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCtrl : MonoBehaviour {

	public Vector2 speed;
	Rigidbody2D rb;
	float lifeTime=3;
	AudioSource aux;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = speed;
		aux = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = speed;
		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.CompareTag("enemy")) {
			//Destroy (col.gameObject);
			aux.Play();
			Destroy (gameObject);
		}
	}
}
