using UnityEngine;
using System.Collections;

public class InventorySystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Hide ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  Hide(){
		GetComponent<Canvas>().enabled = false;
	}

	void Display()
	{
		GetComponent<Canvas>().enabled = true;
	}
}
