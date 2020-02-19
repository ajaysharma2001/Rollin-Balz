using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock2 : MonoBehaviour {

	public GameObject item2;
	public static string item2_text;

	// Use this for initialization
	void Start () {

		StreamReader item2Read = new StreamReader ("Assets/Resources/Item2.txt");
		item2_text = item2Read.ReadToEnd ();

		if (item2_text == "True") {
			item2.gameObject.SetActive (true);
		} else if (item2_text == "False") {
			item2.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
