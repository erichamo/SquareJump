using UnityEngine;
using System.Collections;

public class LevelData : MonoBehaviour {

	/*public static void resetScore() {
		PlayerPrefs.SetInt("lastLevel", 0);
	}
	*/	
	public static void save(int level){
		/*if(getLevel()<=5){
			PlayerPrefs.SetInt("lastLevel", getLevel()+1);
		}*/
		PlayerPrefs.SetInt ("lastLevel",level);
	}

	public static int getLevel(){
		return PlayerPrefs.GetInt("lastLevel",2);
	}

	public static void Reset(){
		PlayerPrefs.SetInt ("lastLevel",2);
		print (LevelData.getLevel());
	}
}
