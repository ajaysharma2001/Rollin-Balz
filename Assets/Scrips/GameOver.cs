using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	bool lvl1 = PlayerController.lvl1;
	bool lvl2 = PlayerController.lvl2;
	bool lvl3 = PlayerController.lvl3;
	bool lvl4 = PlayerController.lvl4;
	bool lvl5 = PlayerController.lvl5;

	public void On_Cick () {

		if (lvl1 == true) {
			Application.LoadLevel ("Level 1");

		} else if (lvl2 == true) {
			Application.LoadLevel ("Level 2");

		} else if (lvl3 == true) {
			Application.LoadLevel ("Level 3");

		} else if (lvl4 == true) {
			Application.LoadLevel ("Level 4");

		} else if (lvl5 == true) {
			Application.LoadLevel ("Level 5");
		}
	}
}
