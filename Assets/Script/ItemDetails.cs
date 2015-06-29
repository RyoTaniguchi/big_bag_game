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

		var hoge3 = GameObject.Find("GM");
		var hoge4 = hoge3.GetComponent<GameManager> ();
		var attack =  hoge4.AttackOrder;
		var order = hoge4.order;

		if (attack [order].power < this.Weight) 
		{
			Debug.Log("buki ga omoi!");
			return;
		}

		var hoge = GameObject.Find ("Enemy");
		var hoge1 = hoge.GetComponent<EnemyHealth> ();
		hoge1.AddjustCurrentHealth (-this.Weight);
		Debug.Log ("Attack!");

		var hoge2 = GameObject.Find("GM");
		hoge2.SendMessage("NextTurn");
	}
}
