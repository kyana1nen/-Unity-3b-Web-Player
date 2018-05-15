using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jump : MonoBehaviour {
	Rigidbody rb;
	Transform y;
	float t=20;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	void Update () {
		t = t - Time.deltaTime;
		Debug.Log (t);
	}
	void OnCollisionEnter (Collision arg) {
		if (arg.gameObject.tag == "floor") {
			Vector3 y = new Vector3 (0, Random.Range(300,700), 0);
			rb.AddForce (y);
		}
	}
}
