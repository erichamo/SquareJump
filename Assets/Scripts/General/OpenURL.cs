using UnityEngine;
using System.Collections;

public class OpenURL : MonoBehaviour {

	public string urlVideo;

	void OnMouseUpAsButton(){
		Application.OpenURL(urlVideo);
	}
}
