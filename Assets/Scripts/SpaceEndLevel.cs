using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpaceEndLevel : MonoBehaviour {
	
	void Update () {

		if (GameObject.Find ("Player").transform.position.z >= 1000) {
			SceneManager.LoadScene("Boat");
		}	
	}
}
