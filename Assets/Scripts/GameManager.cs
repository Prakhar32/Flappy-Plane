using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject Plane;
	public Text ScoreUI;
	public Text HighScoreUI;

	[HideInInspector]
	public static int score;

	// Use this for initialization
	void Start () {
		//Input Key Value pair in PlayerPrefs on first time game starts
		if(Time.realtimeSinceStartup < 1)
		PlayerPrefs.SetInt ("HighScore", 0);

		if (Plane == null) {
			Debug.LogError ("Plane Not Found");
		}

		//Check color of Plane activates plane that matches the color and deactivates the other one
		if (PlayerPrefs.GetInt ("PlaneColor") == 1) {
			GameObject.FindGameObjectsWithTag ("Player") [1].SetActive (false);
			GameObject.FindGameObjectsWithTag ("Player") [0].SetActive (true);
			Plane = GameObject.FindGameObjectsWithTag ("Player") [0];
			Debug.Log (PlayerPrefs.GetInt("Plane"));
		}
			
		else {
			GameObject.FindGameObjectsWithTag ("Player") [0].SetActive (false);
			GameObject.FindGameObjectsWithTag ("Player") [1].SetActive (true);
			Plane = GameObject.FindGameObjectsWithTag ("Player") [1];
		}

		if (ScoreUI == null)
			Debug.LogError ("ScoreUI not found");

		if (HighScoreUI == null)
			Debug.LogError ("HighScoreUI not found");
		
		score = 0;
	}

	void Update () {
		//Displays score and HighScore
		ScoreUI.text = "Score : " + score;
		HighScoreUI.text = "HighScore : " + Mathf.Max (PlayerPrefs.GetInt ("HighScore"), score);
	}

	//Load Specified Scene
	public void LoadScene(){
		SceneManager.LoadScene ("MainMenu");
	}
}
