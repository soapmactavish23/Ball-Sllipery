using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	private float velocidade = 5;
	public Text txtPontos;
	public Camera camera;
	public AudioSource coin;
	private int pontos;
	public GameObject particulaItem;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		txtPontos.text = "Score: " + pontos.ToString();

	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetKeyDown (KeyCode.Escape)){
			SceneManager.LoadScene (0);
		}
	}

	void FixedUpdate () {
		//Movimento do Player
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rb.AddForce(move * velocidade);

		//Reiniciar
		if(rb.transform.position.y < 0){
			Application.LoadLevel (Application.loadedLevel);	
		}
	}

	//Colletar a moeda
	void OnTriggerEnter(Collider outro){
		if(outro.gameObject.CompareTag("item")){
			Instantiate (particulaItem, outro.gameObject.transform.position, Quaternion.identity);
			coin.Play ();
			Destroy(outro.gameObject);
			MarcaPonto ();
		}
	}

	void MarcaPonto(){
		pontos++;
		txtPontos.text = "Score:" + pontos.ToString ();
		if (pontos >= 10) {
			camera.SendMessage ("proximaFase");		
		}
	}
}
