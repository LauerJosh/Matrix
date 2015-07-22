using UnityEngine;
using System.Collections;

public class VictoryOrDefeat : MonoBehaviour {
	float timer;
	bool pause;
	public GameObject cd10, cd9, cd8, cd7, cd6, cd5, cd4, cd3, cd2, cd1;
	bool check10 = false;
	bool check9 = false;
	bool check8 = false;
	bool check7 = false;
	bool check6 = false;
	bool check5 = false;
	bool check4 = false;
	bool check3 = false;
	bool check2 = false;
	bool check1 = false;
	// Use this for initialization
	void Start () 
	{
		timer = 60;
		pause = false;
		menu.GetComponent<UIPanel> ().enabled = false;
		popup.GetComponent<UIPanel> ().enabled = false;

	}
	public GameObject menu;
	public GameObject popup;
	public GameObject player;
	public GameObject camera;
	public Font myFont;
	// Update is called once per frame
	void Update () 
	{
		if (pause == false) 
		{
		

			if (timer <= 0) 
			{
				Application.LoadLevel ("Defeat");
			} 
		
			if (Input.GetKeyDown (KeyCode.Return)) 
			{
				menu.GetComponent<UIPanel> ().enabled = true;
				player.GetComponent<MouseLook>().enabled = false;
				camera.GetComponent<MouseLook>().enabled = false;
				player.GetComponent<CharacterMotor>().enabled = false;
				player.GetComponent<FPSInputController>().enabled = false;
				pause = true;
				camera.transform.LookAt (popup.transform.position);
			}
		} 
		else if (pause == true) 
		{
			if (Input.GetKeyDown (KeyCode.Return)) 
			{
				menu.GetComponent<UIPanel> ().enabled = false;
				player.GetComponent<MouseLook>().enabled = true;
				camera.GetComponent<MouseLook>().enabled = true;
				player.GetComponent<CharacterMotor>().enabled = true;
				player.GetComponent<FPSInputController>().enabled = true;
				pause = false;
			}
		}

		if((timer<=10)&&(check10 == false))
		{
			cd10.GetComponent<AudioSource>().Play();
			check10 = true;
		}
		if((timer<=9)&&(check9 == false))
		{
			cd9.GetComponent<AudioSource>().Play();
			check9 = true;
		}
		if((timer<=8)&&(check8 == false))
		{
			cd8.GetComponent<AudioSource>().Play();
			check8 = true;
		}
		if((timer<=7)&&(check7 == false))
		{
			cd7.GetComponent<AudioSource>().Play();
			check7 = true;
		}
		if((timer<=6)&&(check6 == false))
		{
			cd6.GetComponent<AudioSource>().Play();
			check6 = true;
		}
		if((timer<=5)&&(check5 == false))
		{
			cd5.GetComponent<AudioSource>().Play();
			check5 = true;
		}
		if((timer<=4)&&(check4 == false))
		{
			cd4.GetComponent<AudioSource>().Play();
			check4 = true;
		}
		if((timer<=3)&&(check3 == false))
		{
			cd3.GetComponent<AudioSource>().Play();
			check3 = true;
		}
		if((timer<=2)&&(check2 == false))
		{
			cd2.GetComponent<AudioSource>().Play();
			check2 = true;
		}
		if((timer<=1)&&(check1 == false))
		{
			cd1.GetComponent<AudioSource>().Play();
			check1 = true;
		}


	}
	void FixedUpdate()
	{
		if (pause == false) 
		{
			timer -= Time.fixedDeltaTime;
		}
	}



	void OnGUI()
	{
		GUI.skin.font = myFont;
		GUI.Label(new Rect(0, 0, 100, 100), "<size=50>"+Mathf.Ceil (timer)+"</size>");
	}

	void OnTriggerEnter(Collider other) //When entering the trigger
	{
		if (other.gameObject.tag == "Firewall") //If the trigger is a firewall
		{
			 //You failed!
			Application.LoadLevel ("Defeat");
		}
	}

	void OnTriggerStay(Collider collision)
	{
		if (collision.gameObject.name == "ConsoleWinFullModel(Clone)") 
		{
			//popup.GetComponent<UIPanel>().enabled = true;
			if(Input.GetKeyDown(KeyCode.E))
			{
				Application.LoadLevel (3);
			}

		}

		if (collision.gameObject.name == "ConsoleLoseFullModel(Clone)") 
		{
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				Application.LoadLevel (2);
			}
			//popup.GetComponent<UIPanel>().enabled = true;
		}
	}
	void OnTriggerExit(Collider collision)
	{
		if (collision.gameObject.name == "ConsoleWinFullModel(Clone)") 
		{
			popup.GetComponent<UIPanel>().enabled = false;
			
		}
		
		if (collision.gameObject.name == "ConsoleLoseFullModel(Clone)") 
		{

			popup.GetComponent<UIPanel>().enabled = false;
		}

	}

	public void Resume()
	{
		pause = false;
		menu.GetComponent<UIPanel> ().enabled = false;
		player.GetComponent<MouseLook>().enabled = true;
		player.GetComponent<CharacterMotor>().enabled = true;
		player.GetComponent<FPSInputController>().enabled = true;
	}

	public bool PauseStatus()
	{
		return pause;
	}

	/*void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.rigidbody.name == "ConsoleWinFullModel(Clone)") 
		{
			//Debug.Log ("victoryconsole");
			//victory
			Application.LoadLevel ("Victory");
		} 
		else if (hit.rigidbody.name == "ConsoleLoseFullModel(Clone)") 
		{
			//Debug.Log ("Defeatconsole");
			//defeat
			Application.LoadLevel ("Defeat");
		} 
		Debug.Log ("Collision!");
	}*/
}
