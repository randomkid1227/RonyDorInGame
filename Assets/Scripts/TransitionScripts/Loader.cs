using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {

    public GameObject gameManager;
    public int gameSceneId;

	// Use this for initialization
	void Awake () {
        if (GameManager.instance == null)
            Instantiate(gameManager);
	}

    public void loadSceneOnClick()
    {
        SceneManager.LoadScene(gameSceneId);
    }

}
