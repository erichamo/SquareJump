using UnityEngine;
using System.Collections;

public class PreLoader : MonoBehaviour {

	private AsyncOperation async;
	private float LoadProgress = 0;
	public int LevelToLoad;
	public bool PreloadHigh;
	public bool PreloadLow;
	public bool StartPreload;

	void Start () { 
		if(PreloadHigh){
			Application.backgroundLoadingPriority = ThreadPriority.High; // Good for fast loading when showing progress bars
		}
		if(PreloadLow){
			Application.backgroundLoadingPriority = ThreadPriority.Low; // Good for loading in the background while the game is playing
		}
		if(StartPreload){
			StartCoroutine(LevelLoaderProcess());
		}
	}

	/* MAIN Preload Process */
	IEnumerator LevelLoaderProcess()
	{
		async = Application.LoadLevelAsync(LevelToLoad);
		async.allowSceneActivation = false;
		
		// Wait until finished and get progress
		while( !async.isDone )
		{
			LoadProgress = async.progress;
			if(LoadProgress >= 0.9f)
			{
				//yield return new WaitForSeconds(2.0f);
				async.allowSceneActivation = true;
				yield return async;
				LoadProgress = 1.0f; //Almost done
				break;
			}
			yield return null;
		}
	}
}
