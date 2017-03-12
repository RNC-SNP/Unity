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
		//Control Rigidbody:
		rb.isKinematic = false;//Enable physics;
		rb.useGravity = false;
		rb.AddForce (new Vector3(0, forceY, 0));
		rb.drag = 0.12345f;
		rb.angularVelocity = Vector3.one;
		rb.AddExplosionForce (19.0f, rb.transform.position, 5, 0.1f, ForceMode.Force);
		Debug.Log(rb.GetPointVelocity(Vector3.forward));
	}
}
