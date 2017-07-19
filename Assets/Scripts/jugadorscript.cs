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
	}
}
