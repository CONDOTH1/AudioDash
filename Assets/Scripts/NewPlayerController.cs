using UnityEngine;
using System.Collections;

public class NewPlayerController : MonoBehaviour {
	
	void Update () {

		transform.Translate (0f, 0f, 10f * Time.deltaTime);
	
	}
}
