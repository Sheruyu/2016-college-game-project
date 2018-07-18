using UnityEngine;
using System.Collections;

public class VariableList : MonoBehaviour {
	
	public int counter = 0;
	public float speed = 2.0f; //fruit velocity
	public int lives = 3;
	public bool gameOver = false;
	public bool animationState = false; //also pause on/off boolean
	public int animationNum = 0; //determines which animation is played
	public float animationTime = 1F; //control time between animations. No need to update on start
	public bool settingsOpened = false;


	void Start(){
		DontDestroyOnLoad (gameObject); //same camera is used for every scene, cameras in other scenes are deleted
	}
	
	void FixedUpdate(){
		if (animationState == false) {
			speed *= 1.0002f;
		}
		if (lives <= 0) {
			gameOver = true;
		}
		
	}
}
