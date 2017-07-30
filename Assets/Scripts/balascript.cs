using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascript : MonoBehaviour {

	public float velocidad;
	public int nRebotes;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * velocidad);
	}

	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter2D(Collision2D elotro){
		if (elotro.gameObject.tag.Equals ("Bala")) {
			Destroy (gameObject);

		}else if(elotro.gameObject.tag.Equals ("Pared")){
			nRebotes--;
		}
	}
}
