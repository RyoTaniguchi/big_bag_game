using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] Characters;
	public Health[] AttackOrder; // 現在戦闘中のキャラクターのHealthを、speedの順に入れ替えられた配列

	int n = 2;

	// Use this for initialization
	void Start () {

		// Characters から Healthのクラスの情報だけを抜き出した配列を作る 
		var num = Characters.Length;
		this.AttackOrder = new Health[num];
		for (var i = 0; i < num; i++)
		{
			this.AttackOrder[i] = Characters[i].GetComponent<Health>();
		}

		// AttackOrder という配列をspeedの順に並べ替える 
		for (var i = 0; i < n - 1; i++) {
			for (var j = n - 1; j > i; j--) {
				if (this.AttackOrder [j - 1].speed <= this.AttackOrder [j].speed) {
					var temp = this.AttackOrder [j];
					this.AttackOrder [j] = this.AttackOrder [j - 1];
					this.AttackOrder [j - 1] = temp;
				}
			}
		}

		int a;

		for (a = 0; a < n; a++) 
		{
			Debug.Log (" " + this.AttackOrder [a].speed);
		}
	}

}

