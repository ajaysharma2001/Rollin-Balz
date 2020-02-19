using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


	public static int CoinCount;
	public GameObject cam;
	private Rigidbody rb;
	public float speed = 10;
	private bool wait = true;
	public Material[] material;
	Renderer rend;
	public Text countText;

	public static int amountOne = 100;
	public static int amountTwo = 200;
	public static int amountThree = 300;
	public static int amountFour = 500;
	public static int amountFive = 450;
	public static int amountSix = 350;

	public static bool lvl1 = false;
	public static bool lvl2 = false;
	public static bool lvl3 = false;
	public static bool lvl4 = false;
	public static bool lvl5 = false;



	// Use this for initialization
	void Start () {


		StreamReader coinRead = new StreamReader ("Assets/Resources/CoinCount_File2.txt");
		string CoinCountString = coinRead.ReadToEnd ();
		int.TryParse (CoinCountString, out CoinCount);
		print (CoinCount);
		countText.text = "Coins: " + CoinCount;
		coinRead.Close ();
		rb = GetComponent <Rigidbody> ();
		rend = GetComponent <Renderer> ();
		//rend.sharedMaterial = material [0];

	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (transform.position.y < -20) {
			Application.LoadLevel ("GameOver");
		}

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);

		if (CreatingVar.using1 == true) {
			rend.sharedMaterial = material [1];
		} else if (CreatingVar.using2 == true) {
			rend.sharedMaterial = material [2];
		} else if (CreatingVar.using3 == true) {
			rend.sharedMaterial = material [3];
		} else if (CreatingVar.using4 == true) {
			rend.sharedMaterial = material [4];
		} else if (CreatingVar.using5 == true) {
			rend.sharedMaterial = material [5];
		} else if (CreatingVar.using6 == true) {
			rend.sharedMaterial = material [6];
		} else {
			rend.sharedMaterial = material [0];
		}



	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			print ("Pick Up");
			StreamWriter coinFile = new StreamWriter ("Assets/Resources/CoinCount_File2.txt");
			coinFile.Write (CoinCount += 1);
			print (CoinCount);
			countText.text = "Coins: " + CoinCount;
			coinFile.Close();

		} else if (other.gameObject.CompareTag ("Level 1")) {
			Application.LoadLevel ("Level 1");
			lvl1 = true;
			lvl2 = false;
			lvl3 = false;
			lvl4 = false;
			lvl5 = false;


		} else if (other.gameObject.CompareTag ("Level 2")) {
			Application.LoadLevel ("Level 2");
			lvl1 = false;
			lvl2 = true;
			lvl3 = false;
			lvl4 = false;
			lvl5 = false;
			StreamWriter lvlWrite = new StreamWriter ("Assets/Resources/LvlUnlock_2.txt");
			lvlWrite.Write ("True");
			lvlWrite.Close ();

		} else if (other.gameObject.CompareTag ("Level 3")) {
			Application.LoadLevel ("Level 3");
			lvl1 = false;
			lvl2 = false;
			lvl3 = true;
			lvl4 = false;
			lvl5 = false;
			StreamWriter lvlWrite = new StreamWriter ("Assets/Resources/LvlUnlock_3.txt");
			lvlWrite.Write ("True");
			print ("True");
			lvlWrite.Close ();

		} else if (other.gameObject.CompareTag ("Level 4")) {
			Application.LoadLevel ("Level 4");
			lvl1 = false;
			lvl2 = false;
			lvl3 = false;
			lvl4 = true;
			lvl5 = false;
			StreamWriter lvlWrite = new StreamWriter ("Assets/Resources/LvlUnlock_4.txt");
			lvlWrite.Write ("True");
			lvlWrite.Close ();

		} else if (other.gameObject.CompareTag ("Level 5")) {
			Application.LoadLevel ("Level 5");
			lvl1 = false;
			lvl2 = false;
			lvl3 = false;
			lvl4 = false;
			lvl5 = true;
			StreamWriter lvlWrite = new StreamWriter ("Assets/Resources/LvlUnlock_5.txt");
			lvlWrite.Write ("True");
			lvlWrite.Close ();

		} else if (other.gameObject.CompareTag ("die")) {
			transform.Translate (Vector3.up * 2);
			GetComponent<SphereCollider> ().enabled = false;
			StartCoroutine ("wait3seconds");

		} else if (other.gameObject.CompareTag ("Buy 1")) {
			Application.LoadLevel ("Buy 1");

		} else if (other.gameObject.CompareTag ("Buy 2")) {
			Application.LoadLevel ("Buy 2");

		} else if (other.gameObject.CompareTag ("Buy 3")) {
			Application.LoadLevel ("Buy 3");

		} else if (other.gameObject.CompareTag ("Buy 4")) {
			Application.LoadLevel ("Buy 4");

		} else if (other.gameObject.CompareTag ("Buy 5")) {
			Application.LoadLevel ("Buy 5");

		} else if (other.gameObject.CompareTag ("Buy 6")) {
			Application.LoadLevel ("Buy 6");

		} else if (other.gameObject.CompareTag ("Equip1")) {
			Application.LoadLevel ("Equip1");
		} else if (other.gameObject.CompareTag ("Equip2")) {
			Application.LoadLevel ("Equip2");
		}else if (other.gameObject.CompareTag ("Equip3")) {
			Application.LoadLevel ("Equip3");
		}else if (other.gameObject.CompareTag ("Equip4")) {
			Application.LoadLevel ("Equip4");
		}else if (other.gameObject.CompareTag ("Equip5")) {
			Application.LoadLevel ("Equip5");
		}else if (other.gameObject.CompareTag ("Equip6")) {
			Application.LoadLevel ("Equip6");
		}

	
		
	}

	IEnumerator wait3seconds(){
		yield return new WaitForSeconds (3);
		Application.LoadLevel ("GameOver");
		}




}