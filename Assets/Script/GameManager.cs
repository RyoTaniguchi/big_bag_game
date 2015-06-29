using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] Characters;

	int n = 2;

	// Use this for initialization
	void Start () {

		// Characters から Healthのクラスの情報だけを抜き出した配列を作る 
		var num = Characters.Length;
		var health = new Health[num];
		for (var i = 0; i < num; i++)
		{
			health[i] = Characters[i].GetComponent<Health>();
		}

		// healthという配列をspeedの順に並べ替える 
		for (var i = 0; i < n - 1; i++) {
			for (var j = n - 1; j > i; j--) {
				if (health [j - 1].speed <= health [j].speed) {
					var temp = health [j];
					health [j] = health [j - 1];
					health [j - 1] = temp;
				}
			}
		}

		int a;

		for (a = 0; a < n; a++) 
		{
			Debug.Log (" " + health [a].speed);
		}
	}

}

