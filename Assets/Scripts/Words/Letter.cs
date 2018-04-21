using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Letter {

    public string letter;
    private LetterDisplay display;

    public Letter (string _letter, LetterDisplay _display) {
        letter = _letter;
        display = _display;
        display.SetLetter(letter);
    }
}
