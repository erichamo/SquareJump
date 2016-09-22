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

	// MAIN Preload Process 
	IEnumerator LevelLoaderProcess()
	{
		async = Application.LoadLevelAdditiveAsync(LevelToLoad);
		async.allowSceneActivation = false;
		
		// Wait until finished and get progress
		while( !async.isDone )
		{print("loading "+async.progress);
			LoadProgress = async.progress;
			if(LoadProgress >= 0.9f)
			{
				//yield return new WaitForSeconds(3.0f);
				async.allowSceneActivation = true;
				LoadProgress = 1.0f; //Almost done
				break;
			}
			yield return 0;
		}
	}
}
