﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float levelTime;
    public int score;
    public float startTime;

    public GameObject[] levels;

	// Use this for initialization
	void Start () {

        this.score = 0;
        this.startTime = Time.time;
        this.levelTime *= 0.95f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - this.startTime > levelTime)
        {
            endCurrentLevel();
        }
		
	}

    void endCurrentLevel()
    {
        return;
    }

    //LEVELS ARE SCENES

    void StartNewLevel()
    {
        return;
    }
}
