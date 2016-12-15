using UnityEngine;
using System.Collections;
using System;

public class CirclePacer : MonoBehaviour {

	private Vector3 center = new Vector3(0f,0f,0f);
	private float theta = 0.0f;
	private float radius = 6.0f;
	private float speed = 0.005f;

	void Start () {
		float xNew = center.x + radius * Mathf.Sin (theta);
		float zNew = center.y + radius * Mathf.Cos (theta);
		transform.position = new Vector3 (xNew, 0.75f, zNew);
	}

	// Update is called once per frame
	void Update () {

		theta += speed * Mathf.PI * 2.0f;
		if (theta >= Mathf.PI * 2.0f) {
			theta -= Mathf.PI * 2.0f;
		}
		float xNew = center.x + radius * Mathf.Sin (theta);
		float zNew = center.y + radius * Mathf.Cos (theta);
		transform.position = new Vector3 (xNew, 0.75f, zNew);
	}
}
