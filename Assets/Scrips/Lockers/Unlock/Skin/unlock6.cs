using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock6 : MonoBehaviour {

	public GameObject item6;
	public static string item6_text;

	// Use this for initialization
	void Start () {
		StreamReader item6Read = new StreamReader ("Assets/Resources/Item6.txt");
		item6_text = item6Read.ReadToEnd ();

		if (item6_text == "True") {
			item6.gameObject.SetActive (true);
		} else if (item6_text == "False") {
			item6.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
