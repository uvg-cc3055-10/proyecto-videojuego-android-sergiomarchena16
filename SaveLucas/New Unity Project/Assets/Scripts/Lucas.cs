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
	public GameObject leftBull, rightBull;
	Transform firePos;
//	private float speedo = 10;

	public GameObject laser1;


	AudioSource aux;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		aux = GetComponent<AudioSource>();
		aux.Play();
		firePos = transform.Find("firePos");
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
			anim.SetTrigger ("salto2");
			//speedo = speedo + 1;
		}

		if (Input.GetButtonDown("Fire1")){
			//Debug.Log("Bang");
			anim.SetTrigger ("shoot2");
			fire ();
			//speedo = speedo + 1;
//			if (facingRight == true) {
//				Instantiate (laser1, transform.position, Quaternion.identity);
//			} else if (facingRight == false) {
//				Instantiate(laser1, transform.position , Quaternion.identity);
//			}

		}

	}

	void fire(){
		if (facingRight) {
			Instantiate (rightBull, firePos.position, Quaternion.identity); 
		}
		if (!facingRight) {
			Instantiate (leftBull, firePos.position, Quaternion.identity);
		}
	}
}