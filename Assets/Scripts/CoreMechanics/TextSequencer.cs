using UnityEngine;
using System.Collections;

public class TextSequencer : MonoBehaviour {

	GUIText Text;
	Color targ;

	// Use this for initialization
	void Start () {
		Text = GetComponent<GUIText> ();
		Text.color = new Color (0.5f, 0.5f, 0.5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.T)) {
			targ = new Color(1f, 1f, 1f, 1);
		}
		Text.color = Color.Lerp(Text.color, targ, 3*Time.deltaTime);
	}
}
