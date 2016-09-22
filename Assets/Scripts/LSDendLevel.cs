using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LSDendLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").transform.position.z >= 1000) {
			SceneManager.LoadScene("Road");
		}
	}
}
