using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanquescript : MonoBehaviour {

	public GameObject cabeza;
	public GameObject cuerpo;
	public GameObject municion;
	public float vmovimiento=0.1f;
	public float vRotar=4f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}


	public void disparar(){

		Vector3 pclick=Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float angulo = -(Mathf.Atan2(pclick.x - transform.position.x, pclick.y - transform.position.y )* Mathf.Rad2Deg);
		cabeza.transform.rotation=Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y,angulo ));

		Vector3 normal = new Vector3 (pclick.x - transform.position.x,pclick.y - transform.position.y,0);
		normal.Normalize ();
		float movX = transform.position.x+(normal.x*1.6f);
		float movY = transform.position.y+(normal.y*1.6f);
		Instantiate (municion, new Vector3(movX,movY,0),cabeza.transform.rotation );
	}

	public void mover(string direccion){
		float anguloZ = cuerpo.transform.rotation.eulerAngles.z;
		if (direccion.Equals ("ARRIBA")) {
			if (anguloZ > 200 && anguloZ < 270) {
				rotar ("DER");
			} else if (anguloZ < 340 && anguloZ >= 270) {
				rotar ("IZQ");
			} else if (anguloZ > 20 && anguloZ <= 90) {
				rotar ("DER");
			} else if (anguloZ > 90 && anguloZ < 160) {
				rotar ("IZQ");
			} else if ((anguloZ <= 20 && anguloZ > 0) || (anguloZ <= 200 && anguloZ > 180)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + vmovimiento, transform.position.z);
				rotar ("DER");
			} else if ((anguloZ >= 340 && anguloZ < 360) || (anguloZ >= 160 && anguloZ < 180)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + vmovimiento, transform.position.z);
				rotar ("IZQ");
			} else {
				transform.position = new Vector3 (transform.position.x, transform.position.y + vmovimiento, transform.position.z);
			}

		} else if (direccion.Equals ("ABAJO")) {
			if (anguloZ > 200 && anguloZ <= 270) {
				rotar ("DER");
			} else if (anguloZ < 340 && anguloZ > 270) {
				rotar ("IZQ");
			} else if (anguloZ > 20 && anguloZ < 90) {
				rotar ("DER");
			} else if (anguloZ >= 90 && anguloZ < 160) {
				rotar ("IZQ");
			} else if ((anguloZ <= 20 && anguloZ > 0) || (anguloZ <= 200 && anguloZ > 180)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - vmovimiento, transform.position.z);
				rotar ("DER");
			} else if ((anguloZ >= 340 && anguloZ < 360) || (anguloZ >= 160 && anguloZ < 180)) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - vmovimiento, transform.position.z);
				rotar ("IZQ");
			} else {
				transform.position = new Vector3 (transform.position.x, transform.position.y - vmovimiento, transform.position.z);
			}

		} else if (direccion.Equals ("DER")) {
			if (anguloZ > 290 && anguloZ <= 360) {
				rotar ("DER");
			} else if (anguloZ < 70 && anguloZ >= 0) {
				rotar ("DER");
			} else if (anguloZ > 110 && anguloZ <= 180) {
				rotar ("DER");
			} else if (anguloZ > 180 && anguloZ < 250) {
				rotar ("IZQ");
			} else if ((anguloZ < 90 && anguloZ >= 70) || (anguloZ < 270 && anguloZ >= 250)) {
				transform.position = new Vector3 (transform.position.x + vmovimiento, transform.position.y, transform.position.z);
				rotar ("IZQ");
			} else if ((anguloZ > 270 && anguloZ <= 290) || (anguloZ > 90 && anguloZ <= 110)) {
				transform.position = new Vector3 (transform.position.x + vmovimiento, transform.position.y, transform.position.z);
				rotar ("DER");
			} else {
				transform.position = new Vector3 (transform.position.x + vmovimiento, transform.position.y, transform.position.z);
			}
		
		} else if (direccion.Equals ("IZQ")) {
			if (anguloZ > 290 && anguloZ < 360) {
				rotar ("IZQ");
			} else if (anguloZ < 70 && anguloZ >= 0) {
				rotar ("IZQ");
			} else if (anguloZ > 110 && anguloZ <= 180) {
				rotar ("DER");
			} else if (anguloZ > 180 && anguloZ < 250) {
				rotar ("IZQ");
			} else if ((anguloZ < 90 && anguloZ >= 70) || (anguloZ < 270 && anguloZ >= 250)) {
				transform.position = new Vector3 (transform.position.x - vmovimiento, transform.position.y, transform.position.z);
				rotar ("IZQ");
			} else if ((anguloZ > 270 && anguloZ <= 290) || (anguloZ > 90 && anguloZ <= 110)) {
				transform.position = new Vector3 (transform.position.x - vmovimiento, transform.position.y, transform.position.z);
				rotar ("DER");
			} else {
				transform.position = new Vector3 (transform.position.x - vmovimiento, transform.position.y, transform.position.z);
			}
		}
	}

	private void rotar(string direccion){
		if (direccion.Equals ("DER")) {
			cuerpo.transform.eulerAngles = new Vector3 (transform.rotation.x, transform.rotation.y, 
				cuerpo.transform.rotation.eulerAngles.z - vRotar + Input.GetAxis ("Horizontal"));
		} else if (direccion.Equals ("IZQ")) {
			cuerpo.transform.eulerAngles = new Vector3 (transform.rotation.x, transform.rotation.y, 
				cuerpo.transform.rotation.eulerAngles.z + vRotar + Input.GetAxis ("Horizontal"));
		}
	}
}
