using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanquescript : MonoBehaviour {

	public GameObject municion;
	public float velocidad=0.1f;

	public float posx;
	public float posy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void disparar(){

		float angulo =Vector2.Angle(new Vector2(transform.position.x, transform.position.y), new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		posx = Input.mousePosition.x;
		posy = Input.mousePosition.y;
		transform.rotation=Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y,angulo )) ;
		
		Instantiate (municion, transform.position,transform.rotation );
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
	}
}
