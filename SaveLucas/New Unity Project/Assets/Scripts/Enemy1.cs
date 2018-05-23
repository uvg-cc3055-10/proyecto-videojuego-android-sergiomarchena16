using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
	
	float lifeTime = 3;
	Animator anim;
	Transform firePosE;
	public GameObject acorn;
	public float totalLife=10;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		firePosE = transform.Find("firePosE");
	}
	
	// Update is called once per frame
	void Update () {

		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			anim.SetTrigger("time");
			fire ();
			lifeTime = 5;
		}
	
	}
	void fire(){
		Instantiate (acorn, firePosE.position, Quaternion.identity); 
	}

	void OnCollisionTrigger (Collision col)
	{
		if(col.gameObject.tag == "die")
		{
			col.gameObject.SetActive (false);
		}
	}
}

