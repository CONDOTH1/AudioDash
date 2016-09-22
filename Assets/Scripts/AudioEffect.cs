using UnityEngine;
using System.Collections;

public class AudioEffect : MonoBehaviour {

	public int detail = 1;
	public float amplitude = 0.1f;
	public float startScale;
	void Start () {

		startScale = transform.localScale.y;
	}

	void Update () {
		float[] info = new float[detail];
		AudioListener.GetOutputData (info, 0);
		float packageData = 0.0f;
		for(int x = 0;x < info.Length; x++)
		{
			packageData += System.Math.Abs (info [x]);
		}

		Vector3 temp = transform.localScale; 
		temp.y = (startScale + packageData * amplitude);
		temp.x = (startScale + packageData * amplitude);
		temp.z = (startScale + packageData * amplitude);
		transform.localScale = temp;


	}
}
