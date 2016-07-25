using UnityEngine;
using System.Collections;

public class FollowSquare: MonoBehaviour {

	public Transform sphere;
	public int distance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(sphere.transform.localPosition.x+this.distance,
		                                      transform.localPosition.y,
		                                      transform.localPosition.z);
	}
}
