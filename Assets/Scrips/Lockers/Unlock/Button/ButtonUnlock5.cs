using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock5 : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock5.item5_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock5.item5_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
