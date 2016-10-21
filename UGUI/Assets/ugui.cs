using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ugui : MonoBehaviour {

	private Text t;

	void Start() {
		//Init Text:
		t = this.gameObject.GetComponentInChildren<Text> ();
		t.color = new Color (0f, 1f, 0f, 1f);
		t.text = "Hello, Unity..";


	}

	public void onBtnClcik() {
		Debug.Log ("Button is clicked..");
		t.color = new Color (0f, 0f, 1f, 1f);
		t.text = "Button is clicked..";
	}
}
