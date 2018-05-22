using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testSayfadegis : MonoBehaviour {
	public Color mouseOverColor = new Color32 (255, 255, 255, 175);
	public Color originalColor = Color.white;
	public int[] yanitlar = new int[11];


	public Button sonrakiButon1;
	public Button sonrakiButon2;
	public Button sonrakiButon3;
	public Button sonrakiButon4;
	public Button sonrakiButon5;
	public Button sonrakiButon6;
	public Button sonrakiButon7;
	public Button sonrakiButon8;
	public Button sonrakiButon9;



	public Button oncekiButon2;
	public Button oncekiButon3;
	public Button oncekiButon4;
	public Button oncekiButon5;
	public Button oncekiButon6;
	public Button oncekiButon7;
	public Button oncekiButon8;
	public Button oncekiButon9;
	public Button oncekiButon10;


	public Button btn1d;
	public Button btn2d;
	public Button btn3d;
	public Button btn4d;
	public Button btn5d;
	public Button btn6d;
	public Button btn7d;
	public Button btn8d;
	public Button btn9d;
	public Button btn10d;

	public Button btn1y;
	public Button btn2y;
	public Button btn3y;
	public Button btn4y;
	public Button btn5y;
	public Button btn6y;
	public Button btn7y;
	public Button btn8y;
	public Button btn9y;
	public Button btn10y;

	// SORULAR
	public GameObject soru1;
	public GameObject soru2;
	public GameObject soru3;
	public GameObject soru4;
	public GameObject soru5;
	public GameObject soru6;
	public GameObject soru7;
	public GameObject soru8;
	public GameObject soru9;
	public GameObject soru10;

	public GameObject BasariPanel;
	public GameObject BasarisizPanel;

	public GameObject alistirmasayi;
	public GameObject testiBitir;
	public void Dogru1()
	{yanitlar [1] = 1;}
	public void Yanlis1()
	{yanitlar [1] = 0;}

	public void Dogru2()
	{yanitlar [2] = 1;}
	public void Yanlis2()
	{yanitlar [2] = 0;}

	public void Dogru3()
	{yanitlar [3] = 1;}
	public void Yanlis3()
	{yanitlar [3] = 0;}

	public void Dogru4()
	{yanitlar [4] = 1;}
	public void Yanlis4()
	{yanitlar [4] = 0;}

	public void Dogru5()
	{yanitlar [5] = 1;}
	public void Yanlis5()
	{yanitlar [5] = 0;}

	public void Dogru6()
	{yanitlar [6] = 1;}
	public void Yanlis6()
	{yanitlar [6] = 0;}

	public void Dogru7()
	{yanitlar [7] = 1;}
	public void Yanlis7()
	{yanitlar [7] = 0;}

	public void Dogru8()
	{yanitlar [8] = 1;}
	public void Yanlis8()
	{yanitlar [8] = 0;}

	public void Dogru9()
	{yanitlar [9] = 1;}
	public void Yanlis9()
	{yanitlar [9] = 0;}

	public void Dogru10()
	{yanitlar [10] = 1;}
	public void Yanlis10()
	{yanitlar [10] = 0;}


	public void TestFinish(){
		int sayi = 0;
		int tekrarSayisi = 0;
		int geciciTekrar = 1;

		for (int i = 0; i < yanitlar.Length-1; i++)
		{
			if (yanitlar[i] == yanitlar[i + 1])
				geciciTekrar++;

			if( i==(yanitlar.Length-2) || yanitlar[i] != yanitlar[i+1])
			{
				if (geciciTekrar > tekrarSayisi)
				{
					tekrarSayisi = geciciTekrar;
					sayi = yanitlar[i];
				}

				geciciTekrar = 1;
			}
		}
		if (yanitlar[1] == 1) {
			btn1d.gameObject.SetActive (true);
		} else {
			btn1y.gameObject.SetActive (true);
		}
		if (yanitlar[2] == 1) {
			btn2d.gameObject.SetActive (true);
		} else {
			btn2y.gameObject.SetActive (true);
		}
		if (yanitlar[3] == 1) {
			btn3d.gameObject.SetActive (true);
		} else {
			btn3y.gameObject.SetActive (true);
		}
		if (yanitlar[4] == 1) {
			btn4d.gameObject.SetActive (true);
		} else {
			btn4y.gameObject.SetActive (true);
		}
		if (yanitlar[5] == 1) {
			btn5d.gameObject.SetActive (true);
		} else {
			btn5y.gameObject.SetActive (true);
		}

		if (yanitlar[6] == 1) {
			btn6d.gameObject.SetActive (true);
		} else {
			btn6y.gameObject.SetActive (true);
		}
		if (yanitlar[7] == 1) {
			btn7d.gameObject.SetActive (true);
		} else {
			btn7y.gameObject.SetActive (true);
		}
		if (yanitlar[8] == 1) {
			btn8d.gameObject.SetActive (true);
		} else {
			btn8y.gameObject.SetActive (true);
		}
		if (yanitlar[9] == 1) {
			btn9d.gameObject.SetActive (true);
		} else {
			btn9y.gameObject.SetActive (true);
		}
		if (yanitlar[10] == 1) {
			btn10d.gameObject.SetActive (true);
		} else {
			btn10y.gameObject.SetActive (true);
		}
	

		if ((sayi == 1) && (tekrarSayisi >= 7)) {
		
			BasariPanel.gameObject.SetActive (true);
			BasarisizPanel.gameObject.SetActive (false);
			alistirmasayi.gameObject.SetActive (false);
			testiBitir.gameObject.SetActive (false);
			oncekiButon10.gameObject.SetActive (false);

		
		} else {
			BasarisizPanel.gameObject.SetActive (true);
			BasariPanel.gameObject.SetActive (false);
			alistirmasayi.gameObject.SetActive (false);
			testiBitir.gameObject.SetActive (false);
		}

	}

	public void TestiSifirla()
	{
		yanitlar [0] = 0;
		yanitlar [1] = 0;
		yanitlar [2] = 0;
		yanitlar [3] = 0;
		yanitlar [4] = 0;
		yanitlar [5] = 0;
		yanitlar [6] = 0;
		yanitlar [7] = 0;
		yanitlar [8] = 0;
		yanitlar [9] = 0;
		yanitlar [10] = 0;
		BasarisizPanel.gameObject.SetActive (false);
		BasariPanel.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
		soru1.gameObject.SetActive (true);
		alistirmasayi.gameObject.SetActive (true);

	}
















	public void Soru1()
	{
		soru1.gameObject.SetActive (true);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}

	public void Soru2()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (true);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}
	public void Soru3()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (true);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}
	public void Soru4()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (true);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}

	public void Soru5()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (true);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}

	public void Soru6()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (true);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}

	public void Soru7()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (true);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}

	public void Soru8()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (true);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (false);
	}
	public void Soru9()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (true);
		soru10.gameObject.SetActive (false);
	}
	public void Soru10()
	{
		soru1.gameObject.SetActive (false);
		soru2.gameObject.SetActive (false);
		soru3.gameObject.SetActive (false);
		soru4.gameObject.SetActive (false);
		soru5.gameObject.SetActive (false);
		soru6.gameObject.SetActive (false);
		soru7.gameObject.SetActive (false);
		soru8.gameObject.SetActive (false);
		soru9.gameObject.SetActive (false);
		soru10.gameObject.SetActive (true);

	}
}
