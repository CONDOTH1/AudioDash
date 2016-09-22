using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Button startText;

	void Start () {
		startText = startText.GetComponent<Button> ();
	}

	public void StartLevel () {
		SceneManager.LoadScene("Road");
	}

	public void EasyLevel () {
		SceneManager.LoadScene("Road");
	}

	public void MediumLevel () {
		SceneManager.LoadScene("Space");
	}

	public void HardLevel () {
		SceneManager.LoadScene("Boat");
	}

	public void InsaneLevel () {
		SceneManager.LoadScene("LSD");
	}
}
