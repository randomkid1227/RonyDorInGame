using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour {

    public List<Letter> letters;
    public LetterSpawner letterSpawner;
    public float spawnSpeed;
    public LetterType generatorType;
    public enum LetterType {letter, vowel, word}
    public static string[] letterList = { "א", "ב", "ג", "ד", "ה", "ו", "ז", "ח", "ט", "י", "כ", "ל", "מ", "נ", "ס", "ע", "פ", "צ", "ק", "ר", "ש", "ת" };



    private void Start()
    {
        string generatingFunction;
        if (this.generatorType == LetterType.vowel) generatingFunction = "addVowel";
        else if (this.generatorType == LetterType.letter) generatingFunction = "addLetter";
        else generatingFunction = "addWord";
        InvokeRepeating(generatingFunction, 1f, spawnSpeed);
	}

    public void addLetter() {
        // Added this as prototype, can remove the for loop and keep code inside block to revert.
        for (int i = 0; i < 22; i++)
        {
            Letter letter = new Letter(letterList[i].ToString(), letterSpawner.SpawnLetter());
            letters.Add(letter);
        }
    }
    public void addVowel()
    {
        Letter letter = new Letter(LetterGenerator.GetRandomVowel(), letterSpawner.SpawnLetter());
        letters.Add(letter);
    }
    public void addWord()
    {
        Letter letter = new Letter(LetterGenerator.getWord(), letterSpawner.SpawnLetter());
        letters.Add(letter);
    }
}
