using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy2 : MonoBehaviour {

	public GameObject player;
	public static bool buy_two = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountTwo) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountTwo;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();

			StreamWriter item2Write = new StreamWriter ("Assets/Resources/Item2.txt");
			item2Write.Write ("True");
			item2Write.Close ();

			buy_two = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

		} else if (PlayerController.CoinCount < PlayerController.amountTwo) {
			Application.LoadLevel ("MoreMoney");
		}

	}

	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
