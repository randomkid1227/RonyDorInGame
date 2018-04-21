using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBox : MonoBehaviour {

    public Text letters;
    string text;
	// Use this for initialization
	void Start () {
        letters = gameObject.GetComponent<Text>();
        this.text = "";
	}

    public void appendText (string letter) {

        this.text += letter;
        letters.text = this.text;
    }
}
