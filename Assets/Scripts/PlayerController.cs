using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;
	Vector3 startPos;

	void Update () {
		
		transform.Translate (0f, 0f, Speed * Time.deltaTime);

			
	}

}
