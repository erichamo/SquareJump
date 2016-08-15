using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D otherObj)
	{
		if(otherObj.gameObject.tag == "player") {
			GameController.LoseScene();
		}
		print("YOU LOSE "+otherObj.gameObject);
	}
}
