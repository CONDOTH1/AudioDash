using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BoatEndLevel : MonoBehaviour {

	void Start () {
	
	}
	void Update () {

		if (GameObject.Find ("Player").transform.position.z >= 1010) {
			SceneManager.LoadScene("LSD");
		}
	
	}
}
