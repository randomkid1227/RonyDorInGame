using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScoreManager : MonoBehaviour {

    int highscore = 0;

	// Use this for initialization
	void Start () {
		
        highscore = PlayerPrefs.GetInt("highscore", highscore);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
