using UnityEngine;
using System.Collections;

public class ItemDetails : MonoBehaviour {

	public int Weight;
	public GameObject TargetMonster ;

	// Use this for initialization
	void Start () {
		TargetMonster = GameObject.Find ("Enemy1");
		Debug.Log ("first target = " + TargetMonster);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ItemAttack(){

		var gm = GameObject.Find("GM");
		var gmcomponent = gm.GetComponent<GameManager> ();
		var attack =  gmcomponent.AttackOrder;
		var order = gmcomponent.order;



		// Can player use Weapon?  ~
		if (attack [order].power < this.Weight) 
		{
			Debug.Log("buki ga omoi!");
			return;
		}
		// ~ Can player use Weapon?



		// Get TargetMonster Object ~
		TargetMonster = EnemyHealth.TargetEnemy;
			
		var tage = GameObject.Find ("Enemy1");
		if (!TargetMonster == null) 
		{
			tage = TargetMonster;
		} else {
			TargetMonster = GameObject.Find("Enemy1");
			tage = TargetMonster;
		}
		var monster = tage.GetComponent<EnemyHealth> ();

		Debug.Log("TargetEnemy = " + TargetMonster);
		// ~ Get TargetMonster Object



		// hit or avoided ~
		var p = attack [order].dexterity;
		var e = monster.evasion;
		Debug.Log ("player dexterity = " + p +"  Enemy evasion = " + e);
		var hit = Random.value ;
		var avoid = e / p ;
		if(hit < avoid )
		{
			Debug.Log(TargetMonster.name +" ha hirarito kawasita!");
			gm.SendMessage("NextTurn");
		}
		// ~ hit or avoided


		// Critical Hit? ~
		var critical = Random.value * 100;
		if (critical < 5) 
		{
			Debug.Log("kougeki ga kasutta!");
		} 
		else if (5 <= critical && critical< 90)
		{
			Debug.Log("Nomal attack!");
		}
		else if (90 <= critical)
		{
			Debug.Log("kaisin no itigeki!");
		}
		// ~ Critical Hit?


		monster.AddjustCurrentHealth (-this.Weight);
		Debug.Log ("Attack! To " + TargetMonster);

		gm.SendMessage("NextTurn");
	}
}