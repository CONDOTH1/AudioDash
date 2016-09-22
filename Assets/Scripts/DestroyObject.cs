using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	void Start () {
	
	}
	void Update () {

		if (this.gameObject.transform.position.z < GameObject.Find ("Player").transform.position.z - 5) {
			
			Destroy (this.gameObject);

		}
	
	}
}
