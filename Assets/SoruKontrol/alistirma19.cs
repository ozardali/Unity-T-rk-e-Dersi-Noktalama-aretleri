 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alistirma19 : MonoBehaviour {


	public InputField bosluk1;
	public InputField bosluk2;
	public InputField bosluk3;

	public int yanlis = 0;
	public string dogrucevap = ",";
	public string dogrucevap2 = "virgül";


	public string dogrucevapb = ":";
	public string dogrucevapb2 = "iki nokta üst üste";

	public string dogrucevapc = "!";
	public string dogrucevapc2 = "ünlem";


	public GameObject DogruPanel;
	public GameObject YanlisPanel;
	public GameObject AciklamaPanel;
	public GameObject AlistirmaPanel;

	public GameObject check1;
	public GameObject check2;
	public GameObject check3;

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
		if ((dogrucevap == bosluk1.text) || (dogrucevap2 == bosluk1.text)) {
			check1.gameObject.SetActive (true);
			bosluk1.gameObject.SetActive (false);

		} else {
			hatagerisay = true;
			YanlisPanel.gameObject.SetActive (true);
		}

		if (bosluk2.text != "") {
			if ((dogrucevapb == bosluk2.text) || (dogrucevapb2 == bosluk2.text)) {
				check2.gameObject.SetActive (true);
				bosluk2.gameObject.SetActive (false);

			} else {
				hatagerisay = true;
				YanlisPanel.gameObject.SetActive (true);
			}
		}
		else {
			hatagerisay = true;
			YanlisPanel.gameObject.SetActive (true);
		}
		if (bosluk3.text != "") {
			if ((dogrucevapc == bosluk3.text) || (dogrucevapc2 == bosluk3.text)) {
				check3.gameObject.SetActive (true);
				bosluk3.gameObject.SetActive (false);

			} else {
				hatagerisay = true;
				YanlisPanel.gameObject.SetActive (true);
			}
		}
		else {
			hatagerisay = true;
			YanlisPanel.gameObject.SetActive (true);
		}


		if ((check1.gameObject.activeSelf) && (check2.gameObject.activeSelf) && (check3.gameObject.activeSelf))
		{
			DogruPanel.gameObject.SetActive (true);
			DevamButon.gameObject.SetActive (true);
		}

	}


	void Update(){

		if (hatagerisay) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				yanlis = yanlis + 1;
				if (yanlis == 4) {
					Aciklama();
				} 
				YanlisPanel.gameObject.SetActive(false);
				hatagerisay = false;
				timeLeft = 1.0f;

			}

		}
	}

	

}
