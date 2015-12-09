using UnityEngine;
using System.Collections;

public class EnemyTextController : MonoBehaviour {

	private TextMesh textMesh;
	public string word = "test";

	// Use this for initialization
	void Start () {
		textMesh = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		textMesh.text = word;
	}
	
	// Update is called once per frame
	void Update () {
		textMesh.text = word;
	}
}
