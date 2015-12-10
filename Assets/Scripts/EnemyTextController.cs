using UnityEngine;
using System.Collections;

public class EnemyTextController : MonoBehaviour {

	private TextMesh textMesh;
	public string word;
	public string[] words = {"first", "second", "third", "fourth", "fifth",
		"sixth", "seventh", "eight", "ninth", "tenth"};

	// Use this for initialization
	void Start () {
		textMesh = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		int indexWord = Random.Range(0, words.Length);
		word = words [indexWord];
		textMesh.text = words [indexWord];
	}
	
	// Update is called once per frame
	void Update () {
		textMesh.text = word;
	}
}
