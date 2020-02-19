using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock6 : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock6.item6_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock6.item6_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
