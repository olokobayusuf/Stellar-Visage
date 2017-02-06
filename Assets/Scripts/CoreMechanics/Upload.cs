using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Upload : MonoBehaviour {

	public string firstName;
	public string lastName;
	public string planet;

	// Use this for initialization
	void Start () {
		//StartCoroutine(UploadFile ());
	}

	private byte[] Tex () {
		Texture2D tex = new Texture2D(Screen.width, Screen.height);
		tex.ReadPixels(new Rect(0,0,Screen.width,Screen.height),0,0);
		tex.Apply();
		//System.IO.File.WriteAllBytes ("screen.png", tex.EncodeToPNG ());
		return tex.EncodeToPNG ();
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.U)) {
			StartCoroutine(UploadFile ());
		}
	}

	private IEnumerator UploadFile () {
		WWWForm form = new WWWForm();
		form.AddField ("firstName", firstName);
		form.AddField ("lastName", lastName);
		form.AddField ("planet", planet);
		//yield return new WaitForEndOfFrame ();
		//form.AddBinaryData ("fileToUpload", Tex (), "screen.png", "image/png");
		form.AddBinaryData ("fileToUpload", System.Text.Encoding.UTF8.GetBytes ("hello there"));
		WWW www = new WWW ( "http://ugkk74975440.gcspaceapps.koding.io/uploader.php", form);
		yield return www;
		if (www.error != null) {
			Debug.Log("Error: " + www.error);
		}
		else {
			Debug.Log("Upload successful: " + www.text);
		}
	}
}
