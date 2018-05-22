using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragucnokta : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("ucnokta").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("ucnokta").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("ucnokta").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("ucnoktapanel");
			GameObject.Find ("ucnokta").transform.position = panel.transform.position;
		}

	}

}