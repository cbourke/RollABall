using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float ballSpeed = 100;

	public Text countText;
	public Text winText;

	private Rigidbody rb;

	public AudioSource jingleAudio;

	private int count = 0;

	// Use this for initialization
	//called on the first frame, not a constructor
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//is there a similar method for finding UnityEngine.UI elements?		countText = GameObject.Find ("CountText");
		winText.text = "";
		count = 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	// invoked once before each frame is rendered
	void Update () {
	
	}

	//invoked before any physics calculations are made
	void FixedUpdate() {

		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		//y is zero: no up/down movement
		Vector3 movement = new Vector3 (moveH, 0.0f, moveV);
		rb.AddForce (movement*ballSpeed);
	}

	void SetCountText() {
		this.countText.text = "Count: " + this.count;
		if (count >= 10) {
			this.winText.text = "A winner is you!";
		}
	}

	void OnTriggerEnter(Collider other) {
		//other is a reference to the object collided with
		//destroys the other game object and all its children: Destroy(other.gameObject);
		GameObject go = other.gameObject;
		if (go.CompareTag ("PickUp")) {
			go.SetActive (false);
			this.count++;
			SetCountText ();

			jingleAudio.PlayDelayed(0);
			//jingleAudio.Play(44100);
		}
	}
}
