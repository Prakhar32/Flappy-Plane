using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Rock" || collision.gameObject.tag == "DeathZone") {
			if (PlayerPrefs.GetInt ("HighScore") < GameManager.score) {
				PlayerPrefs.SetInt ("HighScore", GameManager.score);
				PlayerPrefs.Save ();
				GameManager.score = 0;
			}
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	} 
}
