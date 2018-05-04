 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame() {
        // Will activate the next scene in the queue (build options)  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
