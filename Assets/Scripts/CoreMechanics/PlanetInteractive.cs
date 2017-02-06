using UnityEngine;
using System.Collections;

public class PlanetInteractive : MonoBehaviour {

	private Vector3 orig;

	// Use this for initialization
	void Start () {
		orig = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale != orig) {
			transform.localScale = orig;
		}
		transform.localScale = orig;
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit();
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform == transform)
			{
				print ("It's working");
				transform.localScale = 0.9f * orig;
			}
		}
	}

	void Switch () {

	}
}
