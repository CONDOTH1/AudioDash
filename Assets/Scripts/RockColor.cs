using UnityEngine;
using System.Collections;

public class RockColor : MonoBehaviour {

	public Material[] materials;

	void Start () {

		int colorPic = Random.Range(0, materials.Length);

		Renderer rend = GetComponent<Renderer> ();
		if (rend != null){
			rend.material = materials[colorPic];
		}
	}
}
