using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
	public GameObject Object;                
	public float spawnTime = 3f;           
	public Transform[] spawnPoints;       


	void Start ()
	{
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
		
	}

	void Update ()
	{
		if (GameObject.Find ("Player").transform.position.z >= 900f) {
			CancelInvoke ();
		}
	}
		
	void Spawn ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (Object, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
