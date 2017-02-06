//Lust creators here

using UnityEngine;
using System.Collections;

public class AsteroidBelt : MonoBehaviour {

	public float MinRadius = 63f;
	public float MaxRadius = 67f;
	public GameObject Asteroid;
	public bool Kuiper = false;

	// Use this for initialization
	void Start () {
		Vector3 Sun = GameObject.Find ("SunMaster").transform.position;
		Sun.y = 0;

		transform.position = Sun;

		for (int u = 0; u < 90; u++) {
			float radius = Random.Range (MinRadius, MaxRadius);
			float deg = new System.Random(Random.Range(62,77589)).Next(360) * Mathf.Deg2Rad;
			GameObject a = (GameObject)Instantiate(Asteroid, new Vector3(radius*Mathf.Cos(deg),0,radius*Mathf.Sin(deg)) , Random.rotation);
			a.transform.parent = transform;
		}

		if (Kuiper) {
			GameObject.Find("PlutoMaster").transform.parent = transform;
			GameObject.Find("CeresMaster").transform.parent = transform;
			GameObject.Find("ErisMaster").transform.parent = transform;
		}
	}

	void Update () {
		transform.Rotate (Vector3.up * 0.1f);
	}
}
