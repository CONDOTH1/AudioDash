using UnityEngine;
using System.Collections;


public class LSDspawnManager : MonoBehaviour
{
	public GameObject Object;               
	public float spawnTime = 3f;            
	public Transform[] spawnPoints;        


	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}
		
	void Spawn ()
	{

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (Object, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}