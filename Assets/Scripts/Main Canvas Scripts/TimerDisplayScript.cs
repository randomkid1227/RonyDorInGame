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
        timer.text = GameManager.instance.time.ToString();
	}
}
