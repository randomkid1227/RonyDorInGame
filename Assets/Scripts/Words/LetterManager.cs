using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour {

    public List<Letter> letters;
    public LetterSpawner letterSpawner;
    public float spawnSpeed;
    public LetterType generatorType;
    public enum LetterType {letter, vowel}
    

    private void Start()
    {
        string generatingFunction;
        if (this.generatorType == LetterType.vowel) generatingFunction = "addVowel";
        else generatingFunction = "addLetter";
        InvokeRepeating(generatingFunction, 1f, spawnSpeed);
	}

    public void addLetter() {
        Letter letter = new Letter(LetterGenerator.GetRandomWord(), letterSpawner.SpawnLetter());
        letters.Add(letter);
    }
    public void addVowel()
    {
        Letter letter = new Letter(LetterGenerator.GetRandomVowel(), letterSpawner.SpawnLetter());
        letters.Add(letter);
    }
}
