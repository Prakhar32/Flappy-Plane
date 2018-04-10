using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

	//Make Camera Follow Plane is X direction
 	void Update () {
		GameObject[] players= GameObject.FindGameObjectsWithTag ("Player");
		GameObject player = players[0];
		gameObject.transform.position = new Vector3(player.gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
	}
}
