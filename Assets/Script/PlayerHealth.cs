using UnityEngine;
using System.Collections;

public class PlayerHealth : Health {

	public float healthBarLength;

	public GameObject[] UseItem;

	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;

		this.dexterity = Mathf.CeilToInt (this.level * 1.2f + 10);
		this.defense = Mathf.CeilToInt (this.power / 2);
		this.m_defense = Mathf.CeilToInt (this.intelligence / 2);
		this.evasion = Mathf.CeilToInt (this.speed / 10);
	}

	// Update is called once per frame
	void Update () {
	}

	void OnGUI() {
		GUI.Box (new Rect (10, 10, healthBarLength, 20), curHealth + "/" + maxHealth);
	}

	public void AddjustCurrentHealth(int adj){
		curHealth += adj;

		if (curHealth < 0)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		if (maxHealth < 1)
			maxHealth = 1;

		healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
	}


	void Attack(){
		var hoge = GameObject.Find("Inventory");
		hoge.SendMessage ("Display");
	}
	
}