using UnityEngine;
using System.Collections;

public class EnemyMovements : MonoBehaviour {

	public string word = "test";

	Transform player;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	
	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{
		// ... set the destination of the nav mesh agent to the player.
		nav.SetDestination (player.position);
	} 
}
