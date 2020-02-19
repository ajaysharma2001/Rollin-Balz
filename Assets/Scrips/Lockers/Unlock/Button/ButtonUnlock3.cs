using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock3 : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock3.item3_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock3.item3_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
