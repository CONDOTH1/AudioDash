using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseLevelStart : MonoBehaviour {
		
	public void RoadLevel () {
		SceneManager.LoadScene ("Road");
		Time.timeScale = 1;
	}

	public void LsdLevel () {
		SceneManager.LoadScene ("LSD");
		Time.timeScale = 1;
	}

	public void BoatLevel()
	{
		SceneManager.LoadScene ("Boat");
		Time.timeScale = 1;

	}

	public void SpaceLevel()
	{
		SceneManager.LoadScene ("Space");
		Time.timeScale = 1;

	}
}
