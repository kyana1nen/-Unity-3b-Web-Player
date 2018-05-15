using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {
	public GameObject enemy;
	void Start () {
		for (int i = 0; i > 10; i++) {
			Instantiate (enemy);
		}
	}
	void Update () {
		
	}
    void OnMouseDown () {
		Destroy (gameObject);
    }
}