using UnityEngine;
using System.Collections;

public class WhaleController : MonoBehaviour {

	public float Speed;		
		
	void Update () {

		transform.Translate (0, 0, Speed * Time.deltaTime);
	
	}
}
