using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy6 : MonoBehaviour {

	public GameObject player;
	public static bool buy_six = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountSix) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountSix;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();
			buy_six = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

			StreamWriter item6Write = new StreamWriter ("Assets/Resources/Item6.txt");
			item6Write.Write ("True");
			item6Write.Close ();

		} else if (PlayerController.CoinCount < PlayerController.amountSix) {
			Application.LoadLevel ("MoreMoney");
		}

	}
	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
