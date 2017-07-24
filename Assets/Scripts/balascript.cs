using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascript : MonoBehaviour {

	public float velocidad;
	public int nRebotes;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up*velocidad);
	}

	/*
	void OnCollisionEnter2D(Collision2D elotro){
		if (elotro.gameObject.tag.Equals ("ParedExterior")) {
			Destroy (gameObject);
		}
	}*/
}
