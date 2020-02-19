using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class unlock1 : MonoBehaviour {

	public GameObject item1;
	public static string item1_text;

	// Use this for initialization
	void Start () {
		StreamReader item1Read = new StreamReader ("Assets/Resources/Item1.txt");
		item1_text = item1Read.ReadToEnd ();

		if (item1_text == "True") {
			item1.gameObject.SetActive (true);
		} else if (item1_text == "False") {
			item1.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}

