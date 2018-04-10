using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDownwards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(120, 0));
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.rotation.eulerAngles.z);

		if(gameObject.transform.rotation.eulerAngles.z == 0)
			gameObject.transform.Rotate(new Vector3(0, 0, -2.5f));

		if (gameObject.transform.rotation.eulerAngles.z <= 290 && gameObject.transform.rotation.z < 0)
			return;
		
		gameObject.transform.Rotate(new Vector3(0, 0, -2.5f));
	}
}
