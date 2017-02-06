using UnityEngine;
using System.Collections;

public class ForestViz : MonoBehaviour {

	public GameObject Planez;
	public float quads = 10;

	// Use this for initialization
	void Start () {

		float step = 1f / quads;
		float step0 = 0.5f * step;
		Debug.Log (step);

		for (int y = 0; y < quads; y++) {
			float nsp = step0 + (step*y);
			Debug.Log(nsp);
			Vector2 np = new Vector2(nsp, 0.5f);
			Vector3 pos = Camera.main.ViewportToWorldPoint(np);
			//Debug.Log(pos.x);
			GameObject p = (GameObject)Instantiate(Planez, pos, Quaternion.Euler(90,180,0));
			p.transform.position = new Vector3(p.transform.position.x, p.transform.position.y, 24f);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
