using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDisplayScript : MonoBehaviour {

    TMPro.TextMeshProUGUI timer;

	// Use this for initialization
	void Start () {
        timer = GetComponent<TMPro.TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        timer.text = timeFormatBuilder();
	}

    private string timeFormatBuilder()
    {
        int minutes = (int) (GameManager.instance.time / 60.0);
        int seconds = (int) (GameManager.instance.time % 60.0);
        return minutes.ToString() + ":" + seconds.ToString();
    }
}
