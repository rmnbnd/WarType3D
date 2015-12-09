using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	private GameObject[] enemies;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag("Enemy Text");
		if (Input.anyKeyDown) {
			foreach (GameObject enemy in enemies) {
				EnemyTextController enemyObject = enemy.GetComponent<EnemyTextController>();
				if (enemyObject.word[0].ToString() == Input.inputString) {
					if (enemyObject.word.Length == 1) {
						Destroy(enemy.transform.parent.gameObject);
					} else {
						enemyObject.word = enemyObject.word.Substring(1, enemyObject.word.Length - 1);						
					}
				}
			}
		}
	}
}
