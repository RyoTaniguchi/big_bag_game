using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindWithTag("Player");
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
