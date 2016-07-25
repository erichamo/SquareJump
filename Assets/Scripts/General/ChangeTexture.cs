using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour {

	public GameObject ob;//[] objetos;
	public Sprite spr;//[] sprites;
	//int i =0;
	
	
	void OnMouseUpAsButton(){
		ob.GetComponent<SpriteRenderer>().sprite= spr;
	}
}
