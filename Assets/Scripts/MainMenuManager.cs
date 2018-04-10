using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {
	
	public Sprite RedPlane;

	public Sprite GreenPlane;

 	private  Sprite _Plane;
	private int _planeColor;

	//Checks if Mouse was Hovering on Button at time of click or Button was touched
	public bool buttonHover;

	// Use this for initialization
	void Start () {
		if (RedPlane == null)
			Debug.LogError ("RedPlane Sprite not Found");

		if (GreenPlane == null)
			Debug.LogError ("GreenPlane Sprite not Found");
		
		_Plane = GameObject.FindGameObjectWithTag("PlaneImage").GetComponent<Image>().sprite;
		_planeColor = 1;
	}

	//Check if mouse was clicked or Screen touched at any other location that SwitchPlane Button
	//And Load Game Level
	void Update(){
		if ((CrossPlatformInputManager.GetButtonDown ("Fire1") || Input.GetTouch(0).phase == TouchPhase.Began) && !buttonHover) {
			//Storing Plane Color
			PlayerPrefs.SetInt ("PlaneColor", _planeColor);

			//Loading Level
			SceneManager.LoadScene ("Level1");
		}
	}
		
	//Changes Plane Color whenever Switch Color Button is Pressed
	public void ChangeSprite(){
		if (RedPlane == null)
			Debug.Log ("Null");

		if (_Plane == RedPlane) {
			_Plane = GreenPlane;
			_planeColor = 2;
		} else {
			_Plane = RedPlane;
			_planeColor = 1;
		}

		GameObject.FindGameObjectWithTag ("PlaneImage").GetComponent<Image> ().sprite = _Plane;
	}
		
	public void Hovers(){
		buttonHover = true;
	}

	public void notHovers(){
		buttonHover = false;
	}
}
