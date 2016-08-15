using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static string LevelData;
	public static string ScoreData;
	public static int CurrentLevel;
	public static int CurrentScore;

	// Use this for initialization
	void Start () {
		LevelData = "scene";
		ScoreData = "score";
		CurrentLevel = Application.loadedLevel;
		CurrentScore = 0;
	}

	public static void NextScene()
	{
		CurrentLevel++;
		Application.LoadLevel(CurrentLevel);
	}

	public static void LoseScene()
	{
		Application.LoadLevel(CurrentLevel);
	}

	public static void SetBonus(int iBonus)
	{
		CurrentScore = CurrentScore + iBonus;
	}

	public static int GetBonus()
	{
		return CurrentScore;
	}
}
