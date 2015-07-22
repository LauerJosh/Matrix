using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {
	float counter = 0.0f;
	bool direction = true;
	int choice;
	float rotationsPerMinute = 10.0f;
	// Use this for initialization
	void Start () {
		choice = Random.Range(1, 5); //Choose type of animation

	}
	
	// Update is called once per frame
	void Update () {
		if (choice == 1) //Bob up and down
		{
			if (counter >= 3) 
			{
				if (direction == true) 
				{
					direction = false;
				} 
				else if (direction == false) 
				{
					direction = true;
				}
				counter = 0;
			}
			if (direction == true) 
			{
				transform.Translate (Vector3.up*0.01f);
				counter += Time.deltaTime;
			} 
			else if (direction == false) 
			{
				transform.Translate (Vector3.down*0.01f);
				counter += Time.deltaTime;
			}
		} 
		else if (choice == 2) //Rotate in place
		{
			transform.Rotate (0.0f, 1.0f*rotationsPerMinute*Time.deltaTime, 0.0f);
		}
		else if (choice == 3) //Rotate in place
		{
			transform.Rotate (1.0f*rotationsPerMinute*Time.deltaTime, 0.0f, 0.0f);
		}
		else if (choice == 4) //Rotate in place
		{
			transform.Rotate (0.0f, 0.0f, 1.0f*rotationsPerMinute*Time.deltaTime);
		}


	}
}
