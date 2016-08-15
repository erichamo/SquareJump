using UnityEngine;
using System.Collections;

public class DataController : MonoBehaviour {

	public static void setKeyValue(string sKey, int iValue)
	{
		PlayerPrefs.SetInt(sKey, iValue);
	}
	
	public static int GetKeyValue(string sKey)
	{
		return PlayerPrefs.GetInt(sKey);
	}
	
	public static void ResetKey(string sKey, int nValue)
	{
		PlayerPrefs.SetInt(sKey, nValue);
	}

	public static void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}

	public static void DeleteKey(string sKey)
	{
		PlayerPrefs.DeleteKey(sKey);
	}
}
