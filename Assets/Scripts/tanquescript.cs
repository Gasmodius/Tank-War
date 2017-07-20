using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanquescript : MonoBehaviour {

	public GameObject cabeza;
	public GameObject cuerpo;
	public GameObject municion;
	public float velocidad=0.1f;
	//--------para ayudarse--------
	public float posx;
	public float posy;
	public float aux;
	//-----------------------------

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void disparar(){

		float angulo =180-(Mathf.Atan2(transform.position.x - Input.mousePosition.x, transform.position.y - Input.mousePosition.y)*Mathf.Rad2Deg);
		//----para ayudarse--------------
		posx = Input.mousePosition.x;
		posy = Input.mousePosition.y;
		aux = angulo;
		//-------------------------------
		cabeza.transform.rotation=Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y,angulo )) ;
		
		Instantiate (municion, transform.position,cabeza.transform.rotation );
	}

	public void mover(string direccion){
		if(direccion.Equals("ARRIBA")){
			
			transform.position =new Vector3(transform.position.x,transform.position.y+velocidad,transform.position.z);

		}else if(direccion.Equals("ABAJO")){

			transform.position =new Vector3(transform.position.x,transform.position.y-velocidad,transform.position.z);

		}if(direccion.Equals("DER")){

			transform.position =new Vector3(transform.position.x+velocidad,transform.position.y,transform.position.z);
		
		}if(direccion.Equals("IZQ")){
			
			transform.position =new Vector3(transform.position.x-velocidad,transform.position.y,transform.position.z);
		}
		//posx = transform.rotation.eulerAngles.z;
	}
}
