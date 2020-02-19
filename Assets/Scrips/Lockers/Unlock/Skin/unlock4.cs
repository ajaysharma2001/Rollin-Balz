using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock4 : MonoBehaviour {

	public GameObject item4;
	public static string item4_text;

	// Use this for initialization
	void Start () {
		StreamReader item4Read = new StreamReader ("Assets/Resources/Item4.txt");
		item4_text = item4Read.ReadToEnd ();

		if (item4_text == "True") {
			item4.gameObject.SetActive (true);
		} else if (item4_text == "False") {
			item4.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
