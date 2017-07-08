using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascript : MonoBehaviour {

	public float velocidad = 2f;
	public Vector2 direccion;
	public int nRebotes;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

		rb2d.velocity = direccion * velocidad;
	}

	// Update is called once per frame
	void Update () {

	}
}
