using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float rotateX = 15.0f;
	public float rotateY = 30.0f;
	public float rotateZ = 45.0f;

	void Update ()
	{
		transform.Rotate (new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime);
	}
}
