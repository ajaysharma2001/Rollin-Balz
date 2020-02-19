using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItem1 : MonoBehaviour {

	void Start () {

	}

	public void On_Click () {
		CreatingVar.using1 = false;
		CreatingVar.using2 = false;
		CreatingVar.using3 = false;
		CreatingVar.using4 = false;
		CreatingVar.using5 = false;
		CreatingVar.using6 = false;
		CreatingVar.using1 = true;
		Application.LoadLevel ("Main_Menu");
	}
}
