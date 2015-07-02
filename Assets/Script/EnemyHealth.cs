using UnityEngine;
using System.Collections;

public class EnemyHealth : Health {

	public static GameObject TargetEnemy;

	// Use this for initialization
	void Start () {
		this.dexterity = Mathf.FloorToInt (this.level * 1.2f + 10);
		this.defense = Mathf.FloorToInt (this.power / 2);
		this.m_defense = Mathf.FloorToInt (this.intelligence / 2);
		this.evasion = Mathf.FloorToInt (this.speed / 5);
	}

	// Update is called once per frame
	void Update () {
		AddjustCurrentHealth (0);
	}

	public void AddjustCurrentHealth(int adj){
		curHealth += adj;

		if (curHealth < 0)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		if (maxHealth < 1)
			maxHealth = 1;
	}


	void Attack(){
		Debug.Log (this.gameObject.name + " no kougeki!");

		var hoge = GameObject.Find("GM");
		hoge.SendMessage("NextTurn");
	}

	public void IamTarget (){
		TargetEnemy = this.gameObject;
		Debug.Log("Target = " + TargetEnemy);
	}
	
}