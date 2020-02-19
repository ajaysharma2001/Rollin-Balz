using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buy3 : MonoBehaviour {

	public GameObject player;
	public static bool buy_three = false;

	public void On_Click (){
		if (PlayerController.CoinCount >= PlayerController.amountThree) {
			StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
			string CoinCountString = coinRead.ReadToEnd ();
			int.TryParse (CoinCountString, out PlayerController.CoinCount);
			PlayerController.CoinCount = PlayerController.CoinCount - PlayerController.amountThree;
			coinRead.Close ();
			StreamWriter coinWriter = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinWriter.Write (PlayerController.CoinCount);
			coinWriter.Close ();
			buy_three = true;
			print (PlayerController.CoinCount);
			Application.LoadLevel ("Main_Menu");

			StreamWriter item3Write = new StreamWriter ("Assets/Resources/Item3.txt");
			item3Write.Write ("True");
			item3Write.Close ();

		} else if (PlayerController.CoinCount < PlayerController.amountThree) {
			Application.LoadLevel ("MoreMoney");
		}

	}

	public void On_Click_Cancel (){
		Application.LoadLevel ("Main_Menu");
	}
}
