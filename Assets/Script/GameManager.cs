using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject Player;
	public GameObject Enemy;

	int n = 2;
	public int[] x; 

	// Use this for initialization
	void Start () {
		// Kougeki Junban wo Kimeru
		var hoge = Player.GetComponent<PlayerHealth>();
		int PlayerSpeed = hoge.speed;

		var hoge1 = Enemy.GetComponent<EnemyHealth>();
		int EnemySpeed = hoge1.speed;

		Debug.Log (PlayerSpeed);
		Debug.Log (EnemySpeed);

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

		int a;
		
		for (a = 0; a < n ; a++)
			Debug.Log(" "+ x[a]);
	
	}

}

