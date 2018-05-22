using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragnoktali : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("noktalivirgul").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("noktalivirgul").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("noktalivirgul").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("noktalipanel");
			GameObject.Find ("noktalivirgul").transform.position = panel.transform.position;
		}

	}

}
