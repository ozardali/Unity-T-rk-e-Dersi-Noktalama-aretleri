using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragkesme : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("kesmeisareti").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("kesmeisareti").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("kesmeisareti").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("kesmepanel");
			GameObject.Find ("kesmeisareti").transform.position = panel.transform.position;
		}

	}

}
