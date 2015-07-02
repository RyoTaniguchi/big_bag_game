using UnityEngine;
using System.Collections;

public class ItemDetails : MonoBehaviour {

	public int Weight;
	public GameObject TargetMonster ;

	// Use this for initialization
	void Start () {
		TargetMonster = GameObject.Find ("Enemy1");
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log ("target = " + TargetEnemy);
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


		TargetMonster = EnemyHealth.TargetEnemy;





		var hoge = GameObject.Find ("Enemy1");
		hoge = TargetMonster;
		var hoge1 = hoge.GetComponent<EnemyHealth> ();

		Debug.Log("TargetEnemy = " + TargetMonster);

		// var p = attack [order].dexterity;
		// var e = hoge1.evasion;
		// Debug.Log ("player dexterity = " + p +"  Enemy evasion = " + e);
	

		hoge1.AddjustCurrentHealth (-this.Weight);
		Debug.Log ("Attack! To " + TargetMonster);

		var hoge2 = GameObject.Find("GM");
		hoge2.SendMessage("NextTurn");
	}
}