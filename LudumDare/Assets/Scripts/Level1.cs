using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {


	public Collider2D player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.y<=-6)
			SceneManager.LoadScene(1);
	}
}
