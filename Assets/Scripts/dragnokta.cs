using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragnokta : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("nokta").transform.position = Input.mousePosition;
	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("nokta").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("nokta").transform.position = bosluk.transform.position;
		} else {
			GameObject panel = GameObject.Find ("noktapanel");
			GameObject.Find ("nokta").transform.position = panel.transform.position;
		}

	}
}
