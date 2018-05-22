using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragikinokta : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("ikinokta").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("ikinokta").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("ikinokta").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("ikinoktapanel");
			GameObject.Find ("ikinokta").transform.position = panel.transform.position;
		}

	}

}
