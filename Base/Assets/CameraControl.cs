using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public float forceY = 0.123456789f;

	private GameObject cube;
	private Rigidbody rb;

	void Start () {
		cube = GameObject.FindWithTag ("CubeTag");
		rb = cube.GetComponent<Rigidbody> ();
	}

	void Update () {
		rb.AddForce (new Vector3(0, forceY, 0));
	}
}
