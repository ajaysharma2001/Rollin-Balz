using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock2 : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock2.item2_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock2.item2_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
