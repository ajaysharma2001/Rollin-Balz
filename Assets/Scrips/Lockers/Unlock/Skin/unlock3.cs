using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock3 : MonoBehaviour {

	public GameObject item3;
	public static string item3_text;

	// Use this for initialization
	void Start () {
		StreamReader item3Read = new StreamReader ("Assets/Resources/Item3.txt");
		item3_text = item3Read.ReadToEnd ();

		if (item3_text == "True") {
			item3.gameObject.SetActive (true);
		} else if (item3_text == "False") {
			item3.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
