using UnityEngine;
using System.Collections;

public class ItemDetails : MonoBehaviour {

	public int Weight;
	public GameObject TargetEnemy ;

	// Use this for initialization
	void Start () {
		// TargetEnemy = GameObject.Find ("Enemy1");
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

		var tage = GameObject.Find ("Main Camera");
		var tage1 = tage.GetComponent<TapObject> ();
		TargetEnemy = tage1.TargetMonster;

		var hoge = GameObject.Find ("Enemy1");
		if(!TargetEnemy == null)
		{ hoge = TargetEnemy;}
		var hoge1 = hoge.GetComponent<EnemyHealth> ();
		hoge1.AddjustCurrentHealth (-this.Weight);
		Debug.Log ("Attack! To " + TargetEnemy);

		var hoge2 = GameObject.Find("GM");
		hoge2.SendMessage("NextTurn");
	}
}