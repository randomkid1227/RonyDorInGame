using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterGenerator : MonoBehaviour {

    public static string[] letterList = {"א", "ב", "ג", "ד", "ה", "ו", "ז", "ח", "ט", "י", "כ", "ל", "מ", "נ", "ס", "ע", "פ", "צ", "ק", "ר", "ש", "ת"};
    public static string[] vowelList = { "א", "ה", "ו","י"};

    public static string GetRandomWord () {
        int randomIndex = Random.Range(0, letterList.Length);
        string randomLetter = letterList[randomIndex];

        return randomLetter;
        
    }

    public static string GetRandomVowel()
    {
        int randomIndex = Random.Range(0, vowelList.Length);
        string randomLetter = vowelList[randomIndex];

        return randomLetter;

    }
}
