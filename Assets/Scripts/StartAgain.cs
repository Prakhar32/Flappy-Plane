using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAgain : MonoBehaviour {

	public GameObject RockBottom;
	public GameObject RockMiddle;
	public GameObject RockTop;

	//if Player reaches the end of Scene, Send him back to Beginning and re-initialize rocks in random order
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Return") {
			transform.position = new Vector3(GameObject.FindGameObjectWithTag ("Start").transform.position.x, transform.position.y,
				transform.position.z);
			DestroyAndCreate();
		}
	}

	//Destroys rocks and Re-initializes them, one iteration has, at max, 3 rock pair
	void DestroyAndCreate(){
		Debug.Log (GameObject.FindGameObjectWithTag ("ParentRock") == null);
		GameObject.Destroy (GameObject.FindGameObjectWithTag ("ParentRock").transform.GetChild (0).gameObject);
		GameObject.Destroy (GameObject.FindGameObjectWithTag ("ParentRock").transform.GetChild (1).gameObject);
		GameObject.Destroy (GameObject.FindGameObjectWithTag ("ParentRock").transform.GetChild (2).gameObject);

		int choice = (int)(Random.value * 3);
		GenerateRocks (choice, 1);
		choice = (int)(Random.value * 3);
		GenerateRocks (choice, 2);
	    choice = (int)(Random.value * 3);
		GenerateRocks (choice, 3);
	}

	//Generate Rocks, choice denotes the type of Rock Up-Down Pair and number denotes the randomized distance that it must be placed away
	void GenerateRocks(int choice, int number){
		GameObject obj;
		if (choice == 0) {
			obj = Instantiate (RockBottom, GameObject.FindGameObjectWithTag ("ParentRock").transform, false);
			PlaceAtDistance (obj, number);
		} else if (choice == 1) {
			obj = Instantiate (RockMiddle, GameObject.FindGameObjectWithTag ("ParentRock").transform, false);
			PlaceAtDistance (obj, number);
		} else {
			obj = Instantiate (RockTop, GameObject.FindGameObjectWithTag ("ParentRock").transform, false);
			PlaceAtDistance (obj, number);
		}
	}

	//Place Rocks at certain random distance awaydepending upon the number assigned to it
	void PlaceAtDistance(GameObject obj,int number){
		if(number == 1)
			obj.transform.Translate(new Vector3((int)(Random.Range(0, 4)), 0, 0));
		else if(number == 2)
			obj.transform.Translate(new Vector3((int)(Random.Range(6, 10)), 0, 0));
		else
			obj.transform.Translate(new Vector3((int)(Random.Range(12, 14)), 0, 0));
	}
}
