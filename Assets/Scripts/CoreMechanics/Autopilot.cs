using UnityEngine;
using System.Collections;

public class Autopilot : MonoBehaviour {

	public Transform[] Target = new Transform[15];
	public bool GoTarget = false;
	public int index = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GoTarget) {
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Target[index].position - transform.position, Vector3.up), 2*Time.deltaTime);
			transform.Translate(Vector3.forward*0.2f, Space.Self);
		}
	}
}
