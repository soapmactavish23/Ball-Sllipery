using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particula : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("ApagaObjeto", 1.5f);
	}
	
	void ApagaObjeto(){
		Destroy (this.gameObject);
	}
}
