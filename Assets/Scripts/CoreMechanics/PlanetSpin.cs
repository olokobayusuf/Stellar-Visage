using UnityEngine;
using System.Collections;

public class PlanetSpin : MonoBehaviour {

	private Transform Sun;
	public float RevolutionSpeed;
	public float RotationSpeed = 16f;
	private Transform Child;

	// Use this for initialization
	void Start () {
		Sun = GameObject.Find ("Sun").transform;
		Child = transform.GetChild (0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Sun.position, Vector3.up, RevolutionSpeed * Time.deltaTime);
		Child.Rotate (Vector3.up * RotationSpeed);
	}
}
