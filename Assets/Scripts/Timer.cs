using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float time = 0.0f;
	TextMesh tm;

	void Start () {

		tm = GetComponent<TextMesh>();
	
	}
	
	void Update () {

		time += Time.deltaTime;
		tm.text = Mathf.RoundToInt(time).ToString();
	}
}

