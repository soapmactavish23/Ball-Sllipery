using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour {

	public Text txtEnding;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		txtEnding.transform.Translate(Vector2.up * 50 * Time.deltaTime);
		if(txtEnding.transform.position.y >= Screen.height){
			SceneManager.LoadScene (0);
		}
	}
}
