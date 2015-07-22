using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {

	public AudioSource gameMusic;
	// Use this for initialization
	void Start () {
		gameMusic.Play ();
		gameMusic.time = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
