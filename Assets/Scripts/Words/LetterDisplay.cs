 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LetterDisplay : MonoBehaviour {

    public Text text;
    public GameObject answerBox;

    public void SetLetter (string letter) {
        this.answerBox = GameObject.FindGameObjectWithTag("AnswerBox");
        text.text = letter;
    }

    public void SendLetter () {
        answerBox.GetComponent<AnswerBox>().appendText(text.text);
        Debug.Log("Letter sent");
    }
}
