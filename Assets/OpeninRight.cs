using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeninRight : MonoBehaviour {

	public GameObject buttonToClose1;
	public GameObject buttonToClose2;
	public GameObject buttonToClose3;
	public GameObject buttonToClose4;
	//public GameObject buttonWrong;
	public GameObject model;
	public GameObject buttonRight;


	void Start () {

	}

	void OnMouseDown() {
		Open ();
	}

	public void Open(){
		buttonToClose1.SetActive (false);
		buttonToClose2.SetActive (false);
		buttonToClose3.SetActive (false);
		buttonToClose4.SetActive (false);
		//buttonWrong.SetActive (true);
		model.SetActive (false);
		buttonRight.SetActive (true);
	}
}
