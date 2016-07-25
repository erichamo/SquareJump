using UnityEngine;
using System.Collections;

public class DestroyController : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D otherObj) {
		Destroy(otherObj.gameObject);
		print("DESTROY "+otherObj.gameObject);
	}
}
