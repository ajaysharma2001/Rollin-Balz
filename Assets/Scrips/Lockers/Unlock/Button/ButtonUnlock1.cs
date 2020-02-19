using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUnlock1 : MonoBehaviour {

	public GameObject item;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
		if (unlock1.item1_text == "True") {
			gameObject.SetActive (true);
		} else if (unlock1.item1_text == "False") {
			gameObject.SetActive (false);
		}
	}
}
