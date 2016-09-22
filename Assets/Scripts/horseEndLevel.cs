using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class horseEndLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").transform.position.z >= 600) {
			SceneManager.LoadScene("Space");
		}
	}
}
