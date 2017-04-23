using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public Button play, exit;
	public Sprite blue, black, yellow;
	public Image myImageComponent;
	bool blackBoole = false;
	public float BLUERGBred, BLUERGBgreen, BLUERGBblue, BLACKGBred, BLACKRGBgreen, BLACKRGBblue, YELLOWGBred, YELLOWRGBgreen, YELLOWRGBblue;
	float fadeTime = 3f;
	Color colorToFadeTo;
	// Use this for initialization
	void Start () {
		play.onClick.AddListener (this.ExitGame);
		exit.onClick.AddListener (this.StartLevel1);
		blackBoole = false;
		Blue ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void StartLevel1(){
		SceneManager.LoadScene(1);
	}

	public void Blue(){
		myImageComponent.sprite = black;
		colorToFadeTo = new Color (BLACKGBred, BLACKRGBgreen, BLACKRGBblue, 0f);
		myImageComponent.CrossFadeColor (colorToFadeTo, fadeTime, true, true);
		if (!blackBoole) {
			Invoke ("Black", 3f);
		} else {
			Invoke ("Yellow", 3f);
		}
	}

	public void Black(){
		myImageComponent.sprite = blue;
		colorToFadeTo = new Color (BLUERGBred, BLUERGBgreen, BLUERGBblue, 1f);
		myImageComponent.CrossFadeColor (colorToFadeTo, fadeTime, true, true);
		blackBoole = true;
		Invoke("Blue", 3f);
	}

	public void Yellow(){
		myImageComponent.sprite = yellow;
		colorToFadeTo = new Color (YELLOWGBred, YELLOWRGBgreen, YELLOWRGBblue, 1f);
		myImageComponent.CrossFadeColor (colorToFadeTo, fadeTime, true, true);
		Invoke("Blue1", 2.5f);
	}

	public void Blue1(){
		//myImageComponent.sprite = yellow;
		colorToFadeTo = new Color (YELLOWGBred, YELLOWRGBgreen, YELLOWRGBblue, 0f);
		myImageComponent.CrossFadeColor (colorToFadeTo, fadeTime, true, true);
		Invoke("Black", 2.5f);
	}

	//crno plavo crno zuto

}
