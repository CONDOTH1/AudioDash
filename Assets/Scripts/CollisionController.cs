using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		Application.LoadLevel(Application.loadedLevel);

	}
}

