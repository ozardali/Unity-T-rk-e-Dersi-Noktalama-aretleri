using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragtirnak : MonoBehaviour {
	public void Drag()
	{
		GameObject.Find ("tirnak").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("tirnak").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("tirnak").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("tirnakpanel");
			GameObject.Find ("tirnak").transform.position = panel.transform.position;
		}

	}

}