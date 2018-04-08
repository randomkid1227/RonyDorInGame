using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour 
{
	public int PlayerWon;
    public int Levels;
    public int[] DontLoad;
    public int[] Load;
    public int HP;
    public int Score;
    public float Time;

	public static GlobalControl Instance;

	void Awake ()   
	{
		if (Instance == null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy (gameObject);
		}
    }

}
