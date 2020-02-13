using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	//Objetos Publicos
	public Image imgFundo;
	public Button btnJogar;
	public Button btnSair;
	public AudioSource select;

 	// Use this for initialization
	void Start () {
		//Eventos de click nos botoes
		btnJogar.onClick.AddListener(jogar);
		btnSair.onClick.AddListener (sair);
		
		imgFundo.rectTransform.sizeDelta = new Vector2(imgFundo.sprite.rect.width/2, imgFundo.sprite.rect.height/2);
		
	}

	void jogar(){
		select.Play ();
		SceneManager.LoadScene (5);
	}

	void sair(){
		select.Play ();
		Application.Quit ();
	}
}
