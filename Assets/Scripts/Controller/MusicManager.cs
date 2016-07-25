using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour 
{
	private static MusicManager _instance;
	public AudioSource musicaGame;
	public AudioSource[] sourceSounds; //1. win,  2. error
	internal bool stateMusic;
	internal bool stateSound;
	
	public void OnOffMusic(){
		stateMusic = !stateMusic;
		if (stateMusic) {
			for(int i = 0;i<sourceSounds.Length;i++){
				sourceSounds[i].mute = false;
			}
			if(musicaGame!=null){
				musicaGame.mute = false;
			}
		} else {
			for(int i = 0;i<sourceSounds.Length;i++){
				sourceSounds[i].mute = true;
			}
			if(musicaGame!=null){
				musicaGame.mute = true;
			}
		}
	}

	public void OnOffSounds(){
		stateSound = !stateSound;
		if (stateSound) {
			for(int i = 0;i<sourceSounds.Length;i++){
				sourceSounds[i].mute = false;
			}
		} else {
			for(int i = 0;i<sourceSounds.Length;i++){
				sourceSounds[i].mute = true;
			}
		}
	}


	public void PlayMusicGame()
	{
		musicaGame.Play();
	}
	
	public void stopMusicGame()
	{
		musicaGame.Stop ();
	}


	public void PlayJump()
	{
		sourceSounds[0].Play();
	}

	public void PlayError()
	{
		sourceSounds[1].Play();
	}

	public void OffMusicInPause(){
		StartCoroutine(waitDown());
	}

	IEnumerator waitDown(){
		yield return new WaitForSeconds(0.01f);
		if(musicaGame.volume>0.3f){
			musicaGame.volume -=0.01f;
			StartCoroutine(waitDown());
		}
	}

	public void OnMusicInPause(){
		StartCoroutine(waitUp());
	}
	
	IEnumerator waitUp(){
		yield return new WaitForSeconds(0.01f);
		if(musicaGame.volume<=0.99f){
			musicaGame.volume +=0.01f;
			StartCoroutine(waitUp());
		}
	}

	void Start(){
		stateMusic = true;
		stateSound = true;
		PlayMusicGame();
	}

	public static MusicManager instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = GameObject.FindObjectOfType<MusicManager>();
				
				//Tell unity not to destroy this object when loading a new scene!
				if(_instance != null)
					DontDestroyOnLoad(_instance.gameObject);

			}
			
			return _instance;
		}
	}
	
	void Awake() 
	{
		if(_instance == null)
		{
			//If I am the first instance, make me the Singleton
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != _instance)
				Destroy(this.gameObject);
		}
	}
	

}