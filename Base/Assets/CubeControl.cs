using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {

	private Transform mTransform;
	private float screenWidth;

	public float translateSpeedZ = 1.23f;
	public float rotateSpeedX = 12f;
	public float rotateSpeedY = 23f;

	void Start () {
		mTransform = this.transform;
		screenWidth = Screen.width;
		//this.gameObject.GetComponent<Rigidbody> ().useGravity = false;
	}

	void Update () {
		mTransform.Translate (new Vector3(0, 0, translateSpeedZ * Time.deltaTime));
		mTransform.Rotate (new Vector3(0, rotateSpeedY * Time.deltaTime, 0));
		//Handle touch events:
		foreach (Touch touch in Input.touches) {
			Vector2 pos = touch.position;
			Debug.Log ("Touch at: " + pos.x + ", " + pos.y);
			if (touch.phase == TouchPhase.Moved) {
				mTransform.Rotate (new Vector3 (
					pos.y < screenWidth / 2 ? -Time.deltaTime * rotateSpeedX : Time.deltaTime * rotateSpeedX,
					0, 0));
			}
		}
		//Handle Key events:
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyDown (KeyCode.Home)) {
				Application.Quit ();
			}
		}
	}
}
