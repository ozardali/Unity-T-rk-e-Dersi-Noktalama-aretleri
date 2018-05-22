using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragunlem : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("unlem").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("unlem").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("unlem").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("unlempanel");
			GameObject.Find ("unlem").transform.position = panel.transform.position;
		}

	}

}