using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock5 : MonoBehaviour {

	public GameObject item5;
	public static string item5_text;

	// Use this for initialization
	void Start () {
		StreamReader item5Read = new StreamReader ("Assets/Resources/Item5.txt");
		item5_text = item5Read.ReadToEnd ();

		if (item5_text == "True") {
			item5.gameObject.SetActive (true);
		} else if (item5_text == "False") {
			item5.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
