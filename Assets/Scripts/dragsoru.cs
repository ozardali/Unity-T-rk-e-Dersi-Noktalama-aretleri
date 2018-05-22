using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragsoru : MonoBehaviour {

	public void Drag()
	{
		GameObject.Find ("soruisareti").transform.position = Input.mousePosition;


	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("soruisareti").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("soruisareti").transform.position = bosluk.transform.position;
		}
		else {
			GameObject panel = GameObject.Find ("sorupanel");
			GameObject.Find ("soruisareti").transform.position = panel.transform.position;
		}

	}

}