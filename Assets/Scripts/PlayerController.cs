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
		if (Input.GetKeyDown (KeyCode.Space)) {
			foreach (GameObject enemy in enemies) {
				Destroy(enemy);
			}
		}
	}
}
