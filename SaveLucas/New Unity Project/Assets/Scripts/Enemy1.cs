using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
	
	float lifeTime;
	Animator anim;
	Transform firePosE;
	public GameObject acorn;
	public float totalLife=10;
	public GameObject explosion;
	float time2 = 3f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		firePosE = transform.Find("firePosE");
		lifeTime = Random.Range (2, 5);
	}
	
	// Update is called once per frame
	void Update () {

		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			anim.SetTrigger("time");
			fire ();
			lifeTime = Random.Range (2, 5);;
		}
	
	}
	void fire(){
		Instantiate (acorn, firePosE.position, Quaternion.identity); 
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.CompareTag("die")) {
			Instantiate (explosion, col.gameObject.transform.position, Quaternion.identity);
		}
	}
}

