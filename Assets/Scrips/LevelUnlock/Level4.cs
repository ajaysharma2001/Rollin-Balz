using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Level4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StreamReader lvlRead = new StreamReader ("Assets/Resources/LvlUnlock_4.txt");
		string lvltxt = lvlRead.ReadToEnd ();
		if (lvltxt == "True") {
			gameObject.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
