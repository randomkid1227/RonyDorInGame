using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int score;
    public float startTime;

    public static GameManager instance = null;

	private void Awake()
	{
        if (instance == null)
            instance = this;
        else if (instance == this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
        this.score = 0;
	   }

	// Update is called once per frame
	void Update () {
	       if (Time.time - this.startTime > levelTime)
	       {
            // End the game
	       }

	}

}
