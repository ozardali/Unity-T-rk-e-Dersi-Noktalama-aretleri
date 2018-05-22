using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragvirgul : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("virgul").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("virgul").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("virgul").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("virgulpanel");
			GameObject.Find ("virgul").transform.position = panel.transform.position;
		}

	}
}
