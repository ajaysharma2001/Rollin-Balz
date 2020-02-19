using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock4 : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock4.item4_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock4.item4_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
