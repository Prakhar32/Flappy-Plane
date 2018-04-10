using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour {

	//Increase Score if Player Collides with invisible collider which is placed at the exit of Rock Up-Down Pair
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Score") {
			GameManager.score++;
		}
	}
}
