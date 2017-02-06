using UnityEngine;
using System.Collections;

public class Download : MonoBehaviour {

	//https://www.dropbox.com/s/s6facluou2lwnm6/0.txt?dl=0
	string text = "";

	// Use this for initialization
	void Start () {
		StartCoroutine (StartDownload ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator StartDownload () {
		string url = "https://www.dropbox.com/s/s6facluou2lwnm6/0.txt?dl=1";
		WWW www = new WWW(url);
		yield return www;
		text = www.text;
		string[] texts = text.Split (":" [0]);
		Debug.Log(texts[1]);
	}
}
