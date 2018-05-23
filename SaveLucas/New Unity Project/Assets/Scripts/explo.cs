using UnityEngine;
using System.Collections;

public class explo : MonoBehaviour
{

	float lifeTime = 0.3f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		lifeTime += Time.deltaTime * -1;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
		}
	
	}
}

