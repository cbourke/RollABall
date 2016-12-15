using UnityEngine;
using System.Collections;

public class RandomPacer : MonoBehaviour {

	private int counter = 0;
	private int step = 50;
	private System.Random r = new System.Random();

	private float getRandom() {
		return (float) (r.NextDouble () * 18.0 - 9.0);
	}

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (8f, 0.75f, 8f); //new Vector3 (this.getRandom (), 0.75f, this.getRandom ());
	}
	
	// Update is called once per frame
	void Update () {
		counter++;

		if (counter == step) {
			counter = 0;
			transform.position = new Vector3 (this.getRandom (), 0.75f, this.getRandom ());
		}
	}
}
