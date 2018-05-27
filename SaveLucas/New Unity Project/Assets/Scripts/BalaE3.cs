using UnityEngine;
using System.Collections;

public class BalaE3 : MonoBehaviour {
	float lifeTime = 4;

	// Use this for initialization
	void Start (){

	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 13 * Time.deltaTime);
		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	}
}

