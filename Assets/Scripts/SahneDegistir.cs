using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SahneDegistir : MonoBehaviour {


	public void BolumAc (string BolumIsmi)
	{
		
		SceneManager.LoadScene(BolumIsmi);
	}

	public void CikisYap()

	{
		Application.Quit ();
	}


}
