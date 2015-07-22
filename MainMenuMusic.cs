using UnityEngine;
using System.Collections;

public class MainMenuMusic : MonoBehaviour {
	public AudioSource menuMusic;
	// Use this for initialization
	void Start () {
		menuMusic.Play ();
		menuMusic.time = 56;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
