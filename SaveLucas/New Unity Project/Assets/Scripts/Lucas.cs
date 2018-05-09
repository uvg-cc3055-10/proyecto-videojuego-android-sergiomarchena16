using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lucas : MonoBehaviour {

	Rigidbody2D rb2d;
	SpriteRenderer sr;
	private float speed = 6.5f;
	private float jumpForce = 250f;
	private bool facingRight = true;
	Animator anim;
	private bool salto, shoot;

	public GameObject laser1;


	AudioSource aux;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		anim.SetBool ("salto", false);
		aux = GetComponent<AudioSource>();
		aux.Play();
	}

	// Update is called once per frame
	void Update () {
		
		float move = Input.GetAxis("Horizontal");
		if (move != 0) {
			rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
//			cam.transform.position = new Vector3(rb2d.transform.position.x, cam.transform.position.y, cam.transform.position.z);
			facingRight = move > 0;
		}
		sr.flipX = !facingRight;
		anim.SetFloat("speed", Mathf.Abs(move));

		if (Input.GetButtonDown("Jump")) {
			rb2d.AddForce(Vector2.up*jumpForce);
			anim.SetBool ("salto", true);
		}

		if (Input.GetButtonDown("Fire1")){
			//Debug.Log("Bang");
			anim.SetBool ("shoot", true);
			Instantiate(laser1, transform.position, Quaternion.identity);

		}

	}
}