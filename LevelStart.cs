using UnityEngine;
using System.Collections;

public class LevelStart : MonoBehaviour {
	public GameObject ConsoleWin, ConsoleLose, SpawnOne, SpawnTwo, SpawnThree, SpawnFour, SpawnFive, SpawnSix, SpawnSeven, SpawnEight;

	// Use this for initialization
	void Start () {
	
	}
	void Awake()
	{
		int r = Random.Range (1,8); //Randomise winning computer location
		//Debug.Log (r); //testing
		if (r == 1) {
						Instantiate (ConsoleWin, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 2) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 3) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 4) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 5) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 6) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 7) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				} else if (r == 8) {
						Instantiate (ConsoleLose, SpawnOne.rigidbody.position, SpawnOne.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnTwo.rigidbody.position, SpawnTwo.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnThree.rigidbody.position, SpawnThree.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFour.rigidbody.position, SpawnFour.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnFive.rigidbody.position, SpawnFive.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSix.rigidbody.position, SpawnSix.rigidbody.rotation);
						Instantiate (ConsoleLose, SpawnSeven.rigidbody.position, SpawnSeven.rigidbody.rotation);
						Instantiate (ConsoleWin, SpawnEight.rigidbody.position, SpawnEight.rigidbody.rotation);
				}
		}
	// Update is called once per frame
	void Update () {
	
	}
}
