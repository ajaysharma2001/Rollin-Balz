using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy5 : MonoBehaviour {

	public GameObject player;
	public static bool buy_five = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountFive) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountFive;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();
			buy_five = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

			StreamWriter item5Write = new StreamWriter ("Assets/Resources/Item5.txt");
			item5Write.Write ("True");
			item5Write.Close ();

		} else if (PlayerController.CoinCount < PlayerController.amountFive) {
			Application.LoadLevel ("MoreMoney");
		}

	}
	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
