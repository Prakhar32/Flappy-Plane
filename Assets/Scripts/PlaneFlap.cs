using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlaneFlap : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Jump") || CrossPlatformInputManager.GetButtonDown ("Fire1") ||
			Input.GetTouch(0).phase == TouchPhase.Began) {
			//Debug.Break ();
			if(transform.rotation.eulerAngles.z < 55 || transform.rotation.eulerAngles.z > 280)
				GetComponent<Rigidbody2D> ().AddTorque (1.5f, ForceMode2D.Impulse);
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, 200));
			Debug.Log (transform.rotation.eulerAngles.z);

			if (transform.rotation.eulerAngles.z > 80 && transform.rotation.eulerAngles.z < 180) {
				transform.rotation.eulerAngles.Set (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 70);
				Debug.Log ("If executed");
			}
		}
	}
}
