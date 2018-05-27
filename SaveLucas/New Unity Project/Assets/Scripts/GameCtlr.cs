using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCtlr : MonoBehaviour {


	bool ended=false;
	public int score = 0;
	public int lives = 2;
	public int lives2 = 2;
	public static GameCtlr instance;
	public static GameCtlr instance2;

	// Use this for initialization
	void Start () {
		instance = this;
		instance2 = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndGame(){
		
		if (ended == false) {
			ended = true;
			Debug.Log ("GAME OVER");
			Restart ();
		}
	}

	void Restart(){
		SceneManager.LoadScene ("Level1");
	}


}
