using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy4 : MonoBehaviour {

	public GameObject player;
	public static bool buy_four = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountFour) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountFour;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();
			buy_four = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

			StreamWriter item4Write = new StreamWriter ("Assets/Resources/Item4.txt");
			item4Write.Write ("True");
			item4Write.Close ();

		} else if (PlayerController.CoinCount < PlayerController.amountFour) {
			Application.LoadLevel ("MoreMoney");
		}

	}
	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
