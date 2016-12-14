using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//instead of setting it in the IDE, we can do it via the script:
		player = GameObject.Find ("Ball");

		offset = transform.position - player.transform.position;
	}
	
	// called once per frame, but after all Update() methods have been invoked
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
