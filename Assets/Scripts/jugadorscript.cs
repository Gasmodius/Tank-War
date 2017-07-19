using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorscript : MonoBehaviour {

	public GameObject tanque;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			tanque.SendMessage("disparar");

		}

		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

			tanque.SendMessage("mover","IZQ");

		}else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

			tanque.SendMessage("mover","ARRIBA");

		}else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

			tanque.SendMessage("mover","DER");

		}else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

			tanque.SendMessage("mover","ABAJO");

		}

	}
}
