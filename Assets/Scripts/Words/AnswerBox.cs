using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBox : MonoBehaviour {

    public Text letters;

	// Use this for initialization
	void Start () {
        letters.text = "";
	}

    public void appendText (string letter) {
        letters.text += letter;
    }
}
