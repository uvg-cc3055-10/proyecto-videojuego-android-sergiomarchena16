using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy3 : MonoBehaviour {

	float lifeTime;
	Animator anim;
	Transform firePosE;
	public GameObject acorn;
//	public float totalLife=10;
	public GameObject explosion;
	//	float time2 = 3f;
	float life = 5;
	public Text scoreText;
	public AudioSource aux;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		firePosE = transform.Find("firePosE");
		lifeTime = Random.Range (2, 3);
		//		scoreText.text = "Score: " + GameCtlr.instance.score.ToString ();
		scoreText.text = "Score: " + FindObjectOfType<GameCtlr>().score.ToString();
		aux = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			anim.SetTrigger("time");
			fire ();
			lifeTime = Random.Range (2, 3);;
		}

	}
	void fire(){
		Instantiate (acorn, firePosE.position, Quaternion.identity); 
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.CompareTag("die")) {
			if (life <= 5 && life > 0) {
				Instantiate (explosion, col.gameObject.transform.position, Quaternion.identity);
				GameCtlr.instance.score++;
				scoreText.text = "Score: " + GameCtlr.instance.score.ToString ();
				life = life - 1;
			} else if (life == 0) {
				Destroy (this.gameObject);
				//pasar a level 3
			}
		}
	}
}

