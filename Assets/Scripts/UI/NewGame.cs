using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {

    GameObject gameManager;

	public void newGame ()
    {
        Destroy(GameManager.instance.gameObject);
        SceneManager.LoadScene(1);
    }
}
