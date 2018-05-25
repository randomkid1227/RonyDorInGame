using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplayScript : MonoBehaviour {

    // Use this for initialization
    TMPro.TextMeshProUGUI score;

    // Use this for initialization
    void Start()
    {
        score = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = GameManager.instance.score.ToString();
    }
}
