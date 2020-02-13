using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour {

	public GameObject objCam;
	private Vector3 posicaoInicial;
	public int nextScene;

	// Use this for initialization
	void Start () {
		posicaoInicial = transform.position - objCam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = objCam.transform.position + posicaoInicial;
	}
	void proximaFase(){
		SceneManager.LoadScene (nextScene);
	}
}
