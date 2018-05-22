using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerName : MonoBehaviour {

	public InputField adiniztext;
	public Text username;
	// Use this for initialization
	void Start () {
		username.text = PlayerPrefs.GetString ("username");	
	}

	public void SaveUsername(string username)
	{
		PlayerPrefs.SetString ("username", adiniztext.text);
	}

}
