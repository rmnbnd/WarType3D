using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

	public Terrain terrain;
	public int numberOfObjects;
	private int currentObjects;
	public GameObject objectToPlace;
	private int terrainWidth;
	private int terrainLength;
	private int terrainPosX;
	private int terrainPosZ;

	// Use this for initialization
	void Start ()
	{
		terrainWidth = (int)terrain.terrainData.size.x;
		terrainLength = (int)terrain.terrainData.size.z;
		terrainPosX = (int)terrain.transform.position.x;
		terrainPosZ = (int)terrain.transform.position.z;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(currentObjects <= numberOfObjects)
		{
			int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
			int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
			float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
			GameObject newObject = (GameObject)Instantiate(objectToPlace, new Vector3(posx, posy, posz), Quaternion.identity);
			currentObjects += 1;
		}
		if(currentObjects == numberOfObjects)
		{
			Debug.Log("Generate objects complete!");
		}
	}
}
