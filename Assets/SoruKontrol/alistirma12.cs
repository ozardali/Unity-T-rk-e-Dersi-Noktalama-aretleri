using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alistirma12 : MonoBehaviour {


	public InputField Bosluk;

	public int yanlis = 0;
	public string dogrucevap = ":";
	public string dogrucevap2 = "iki nokta üstüste";
	public GameObject DogruPanel;
	public GameObject YanlisPanel;
	public GameObject AciklamaPanel;
	public GameObject AlistirmaPanel;

	public GameObject DevamButon;


	public bool hatagerisay = false;
	public float timeLeft = 1.0f;

	void Aciklama(){
		AlistirmaPanel.gameObject.SetActive (false);
		AciklamaPanel.gameObject.SetActive(true);
		DevamButon.gameObject.SetActive(true);
	}

	public void Kontrolet()
	{
		if ((dogrucevap == Bosluk.text) || (dogrucevap2 == Bosluk.text)) {
			DogruPanel.gameObject.SetActive (true);
			YanlisPanel.gameObject.SetActive (false);
			DevamButon.gameObject.SetActive (true);
		} else {
			hatagerisay = true;
			YanlisPanel.gameObject.SetActive (true);
		}
	}


	void Update(){

		if (hatagerisay) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				yanlis = yanlis + 1;
				if (yanlis == 3) {
					Aciklama();
				} 
				YanlisPanel.gameObject.SetActive(false);
				hatagerisay = false;
				timeLeft = 1.0f;

			}

		}
	}

	

}
