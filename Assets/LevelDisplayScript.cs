using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDisplayScript : MonoBehaviour {

    // Use this for initialization
    TMPro.TextMeshProUGUI level;

    // Use this for initialization
    void Start()
    {
        level = GetComponent<TMPro.TextMeshProUGUI>();
        level.text = GameManager.instance.level.ToString();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
