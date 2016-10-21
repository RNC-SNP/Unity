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
	private Button btn;

	void Start() {
		//Text:
		txt = this.gameObject.GetComponentInChildren<Text> ();
		txt.color = new Color (0f, 1f, 0f, 1f);
		txt.text = "Hello, Unity..";

		//Image:
		img = this.gameObject.GetComponentInChildren<Image> ();
		StartCoroutine(loadImage (img, uri));//Use coroutine to load image from URL

		//Button:
		btn = this.gameObject.GetComponentInChildren<Button> ();
		btn.onClick.AddListener (//Add listener dynamically
			delegate() {
				txt.color = new Color (0f, 0f, 1f, 1f);
				txt.text = "Button is clicked..";
			}
		);
	}


	private IEnumerator loadImage (Image img, string uri) {
		WWW www = new WWW(uri);
		yield return www;//Wait for data fetching
		if (www.texture != null) {
			Sprite sprite = Sprite.Create(www.texture, 
				new Rect (0, 0, www.texture.width, www.texture.height), 
				new Vector2 (0.5f, 0.5f));
			img.sprite = sprite;
		}
	}
}
