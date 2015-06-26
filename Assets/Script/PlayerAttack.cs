using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Attack(){
		var hoge = GameObject.Find ("Enemy");
		var hoge1 = hoge.GetComponent<EnemyHealth> ();
		hoge1.AddjustCurrentHealth (-50);
		Debug.Log ("Attack!");
	}
}
