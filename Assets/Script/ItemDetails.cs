using UnityEngine;
using System.Collections;

public class ItemDetails : MonoBehaviour {

	public int Weight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ItemAttack(){
		var hoge = GameObject.Find ("Enemy");
		var hoge1 = hoge.GetComponent<EnemyHealth> ();
		hoge1.AddjustCurrentHealth (-this.Weight);
		Debug.Log ("Attack!");

		var hoge2 = GameObject.Find("GM");
		hoge2.SendMessage("NextTurn");
	}
}
