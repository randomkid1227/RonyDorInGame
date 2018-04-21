using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBox : MonoBehaviour {

    public Text letters;
    public string text;
	// Use this for initialization
	void Start () {
//        letters = gameObject.GetComponent<Text>();
        this.text = "";
	}

    public void appendText (string letter) {
        Debug.Log("Writing text");
        this.text += letter;
        letters.text = this.text;
        Debug.Log("String is now " + this.letters.text);
        Destroy(letters.GetComponent<GameObject>());
    }
     public void wipeText()
    {
        this.text = " ";
        letters.text = this.text;
        Debug.Log("Removed text");
        Debug.Log(this.letters.text);
    }
}
