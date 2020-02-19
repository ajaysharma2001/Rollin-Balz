using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy1 : MonoBehaviour {

	public GameObject player;
	public static bool buy_one = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountOne) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountOne;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();
			buy_one = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

			StreamWriter item1Write = new StreamWriter ("Assets/Resources/Item1.txt");
			item1Write.Write ("True");
			item1Write.Close ();

		} else if (PlayerController.CoinCount < PlayerController.amountOne) {
			Application.LoadLevel ("MoreMoney");
		}
	}

	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
