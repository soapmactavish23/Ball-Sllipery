using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour {

	public int scene;
	private float tempo;

	// Use this for initialization
	void Start () {
		tempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		tempo = Time.time;
		if (tempo >= 5) {
			SceneManager.LoadScene (scene);
			tempo = 0;
		}
	}
}
