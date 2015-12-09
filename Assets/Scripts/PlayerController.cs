using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	private GameObject[] enemies;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			if (currentEnemy == null) {
				foreach (GameObject enemy in enemies) {
					EnemyMovements enemyObject = enemy.GetComponent<EnemyMovements>();
					if (enemyObject.word[0].ToString() == Input.inputString) {
						if (enemyObject.word.Length == 1) {
							Destroy(enemy);
						} else {
							enemyObject.word = enemyObject.word.Substring(1, enemyObject.word.Length - 1);						
						}
					}
				}
			}
		}
	}
}
