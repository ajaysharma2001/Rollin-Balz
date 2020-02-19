using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Vector3 offset;
	public GameObject player;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;

	}

	void OnTriggerEnter (Collider rotate) {
		if (rotate.gameObject.CompareTag ("Pick Up")){
			print ("Rotate");
			transform.parent = player.transform;
			player.transform.Rotate (0, 25 *Time.deltaTime, 0);
		}

	}
}
