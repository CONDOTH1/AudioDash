using UnityEngine;
using System.Collections;

public class FourLaneController : MonoBehaviour {
	public Transform Lane1;
	public Transform Lane2;
	public Transform Lane3;
	public Transform Lane4;

	void Update () {

		float fracJourney = 1.0f;

		if (Input.GetKeyDown ("right")) {
			if (Time.timeScale != 0) 
			{
				if (gameObject.transform.position == Lane1.transform.position) {

					transform.position = Vector3.Lerp (Lane1.transform.position, Lane2.transform.position, fracJourney);
				}
				else if (gameObject.transform.position == Lane2.transform.position) {
					transform.position = Vector3.Lerp (Lane2.transform.position, Lane3.transform.position, fracJourney);
				}
				else if (gameObject.transform.position == Lane3.transform.position) {
					transform.position = Vector3.Lerp (Lane3.transform.position, Lane4.transform.position, fracJourney);
				}
			}
		}
			
		if (Input.GetKeyDown ("left")) {
			if (Time.timeScale != 0) {
				if (gameObject.transform.position == Lane4.transform.position) {
					transform.position = Vector3.Lerp (Lane4.transform.position, Lane3.transform.position, fracJourney);
				} else if (gameObject.transform.position == Lane3.transform.position) {
					transform.position = Vector3.Lerp (Lane3.transform.position, Lane2.transform.position, fracJourney);
				} else if (gameObject.transform.position == Lane2.transform.position) {
					transform.position = Vector3.Lerp (Lane2.transform.position, Lane1.transform.position, fracJourney);
				}
			}
		}
	}
}
