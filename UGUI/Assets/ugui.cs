using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ugui : MonoBehaviour {

	private string imgPath {
		get {
			return "https://Rinc.site/img/avatar.jpg";
		}
	}

	private Text txt;
	private Image img;

	void Start() {
		//Init Text:
		txt = this.gameObject.GetComponentInChildren<Text> ();
		txt.color = new Color (0f, 1f, 0f, 1f);
		txt.text = "Hello, Unity..";

		//Init Image:
		img = this.gameObject.GetComponentInChildren<Image> ();
		loadImageAsync (img, imgPath);
	}

	public void onBtnClcik() {
		Debug.Log ("Button is clicked..");
		txt.color = new Color (0f, 0f, 1f, 1f);
		txt.text = "Button is clicked..";
	}


	private void loadImageAsync (Image img, string uri) {
		//Use coroutine to load
		StartCoroutine(loadImage (img, uri));
	}

	private IEnumerator loadImage (Image img, string uri) {
		WWW www = new WWW(uri);
		//Wait for the download
		yield return www;
		if (www.texture != null) {
			Sprite sprite = Sprite.Create(www.texture, 
				new Rect (0, 0, www.texture.width, www.texture.height), 
				new Vector2 (0.5f, 0.5f));
			img.sprite = sprite;
		}
	}
}
