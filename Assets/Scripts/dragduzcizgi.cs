using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragduzcizgi : MonoBehaviour {
	


	public void Drag()
	{
		GameObject.Find ("duzcizgi").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("duzcizgi").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("duzcizgi").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("duzpanel");
			GameObject.Find ("duzcizgi").transform.position = panel.transform.position;
		}

	}

}
