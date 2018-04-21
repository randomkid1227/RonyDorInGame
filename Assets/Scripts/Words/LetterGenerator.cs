using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterGenerator : MonoBehaviour {

    public static string[] letterList = {"א", "ב", "ג", "ד", "ה"};

    public static string GetRandomWord () {
        int randomIndex = Random.Range(0, letterList.Length);
        string randomLetter = letterList[randomIndex];

        return randomLetter;
    }
}
