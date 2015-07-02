using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// ability 
	public int maxHealth ;
	public int curHealth ;
	public int speed ;
	public int power ;
	public int intelligence;
	public int level ;
	public float dexterity;
	public float defense ;
	public float m_defense ;
	public float evasion ;

	// Use this for initialization
	void Start () {
		// dexterity = level * 1.2f + 10;
		// Mathf.CeilToInt (dexterity);

		defense = power / 2;
		Mathf.CeilToInt (defense);

		m_defense = intelligence / 2;
		Mathf.CeilToInt (m_defense);

		evasion = speed / 10;
		Mathf.CeilToInt (evasion);
	}

	// Update is called once per frame
	void Update () {

	}
}
