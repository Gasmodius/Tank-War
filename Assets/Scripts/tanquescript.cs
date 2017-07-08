using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanquescript : MonoBehaviour {

	public GameObject municion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void disparar(){
		Instantiate (municion, transform.position, Quaternion.identity);

	}
}
