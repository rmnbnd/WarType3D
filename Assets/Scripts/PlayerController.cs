using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	private GameObject[] enemies;
	private GameObject currentEnemy;
	private int scoreInc = 10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			if (currentEnemy != null) {
				checkWord(currentEnemy);
				return;
			}
			enemies = GameObject.FindGameObjectsWithTag("Enemy Text");
			foreach (GameObject enemy in enemies) {
				if (checkWord(enemy)) {
					currentEnemy = enemy;
					return;
				}
			}
		}
	}

	private bool checkWord(GameObject enemy) {
		bool isSelectWord = false;
		EnemyTextController enemyObject = enemy.GetComponent<EnemyTextController>();
		if (enemyObject.word[0].ToString() == Input.inputString) {
			enemyObject.textMesh.color = Color.red;
			isSelectWord = true;
			if (enemyObject.word.Length == 1) {
				Destroy(enemy.transform.parent.gameObject);
			} else {
				enemyObject.word = enemyObject.word.Substring(1, enemyObject.word.Length - 1);						
			}
			ScoreManager.score += scoreInc;
		}
		return isSelectWord;
	}
}
