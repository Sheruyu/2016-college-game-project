using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public VariableList target1;

	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}

	void OnTriggerEnter2D(Collider2D co) {
		
		if (co.name == "centerObject") {
			Destroy (gameObject);
		}
		else if (co.name == "greenmonster_0") {
			if(gameObject.name.Equals ("greenFruit(Clone)")){
			   target1.counter++; //increment score
			   target1.animationNum = 3;
			   target1.animationTime = Time.time + .5F;
			}
			else{
				target1.lives--; //decrement lives
				target1.animationNum = 4;
				target1.animationTime = Time.time + .5F;
			}
			Destroy (gameObject);
		}
	}
}
