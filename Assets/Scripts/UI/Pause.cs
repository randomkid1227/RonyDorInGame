using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;


    public void pauseGame() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameManager.instance.stopTimer();
        gameIsPaused = true;
    }

    public void resumeGame() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameManager.instance.startTimer();
        gameIsPaused = false;
    }

    public void stopGame() {
        Application.Quit();
    }
}
