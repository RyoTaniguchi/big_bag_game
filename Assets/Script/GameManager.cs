using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] Characters;
	// public GameObject Player;
	// public GameObject Enemy;

	int n = 2;
	// public int[] x;

	// Use this for initialization
	void Start () {
		// Kougeki Junban wo Kimeru
		// var hoge = Player.GetComponent<PlayerHealth>();
		// int PlayerSpeed = hoge.speed;

		// var hoge1 = Enemy.GetComponent<EnemyHealth>();
		// int EnemySpeed = hoge1.speed;

		// Characters から Healthのクラスの情報だけを抜き出した配列を作る
		var num = Characters.Length;
		var health = new Health[num];
		for (var i = 0; i < num; i++)
		{
			health[i] = Characters[i].GetComponent<Health>();
		}

		// Debug.Log (PlayerSpeed);
		// Debug.Log (EnemySpeed);

		/*
		x = new int[]{PlayerSpeed,EnemySpeed};

		int i, j, temp;

		for (i = 0; i < n - 1; i++) {
			for (j = n - 1; j > i; j--) {
				if (x [j - 1] <= x [j]) {
					temp = x [j];
					x [j] = x [j - 1];
					x [j - 1] = temp;
				}
			}
		}
		*/

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

		for (a = 0; a < n ; a++)
			Debug.Log(" "+ health[a].speed);

	}

}

