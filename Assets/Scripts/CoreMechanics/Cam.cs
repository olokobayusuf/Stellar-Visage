using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cam : MonoBehaviour {

	public int index = 0;
	public Vector3[] Target = new Vector3[15];
	public GameObject target;
	public float side = 0;
	public float height = 2f;
	public float dist = 10f;

	public struct TargetBase {
		public Vector3 Pos;
		public Quaternion Rot;

		public TargetBase (Vector3 p, Quaternion r) {
			Pos = p;
			Rot = r;
		}
	}

	public List<TargetBase> Targets = new List<TargetBase>();

	//Index 0 is looking down at spaceship
	//index 1 is behind cam following cam

	// Use this for initialization
	void Start () {
		Target [0] = transform.position;
		Targets.Add(new TargetBase(transform.position, transform.rotation));
		Targets.Add (new TargetBase(new Vector3( 4.85f, 2.85f,-5.87f), Quaternion.Euler(17.4f, 38.8f, 0) ) );
	}
	
	// Update is called once per frame
	void LateUpdate () { /*
		if (Input.GetKeyUp (KeyCode.S)) {
			Shift (1);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			Shift (2);
		}

		transform.position = Vector3.Lerp (transform.position, Targets [index].Pos, 3 * Time.deltaTime);
		transform.rotation = Quaternion.Slerp(transform.rotation, Targets[index].Rot, 3*Time.deltaTime);*/

		Vector3 tpoint = target.transform.TransformPoint (side, height, dist);
		transform.position = Vector3.Slerp (transform.position, tpoint, 3 * Time.deltaTime);
	}

	void Shift (int i) {
		if (i == 1) {
			index += 1;
		} else {
			index -= 1;
		}

	}
}
