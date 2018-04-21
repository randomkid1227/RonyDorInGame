using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour {

    public List<Letter> letters;
    public LetterSpawner letterSpawner;

    private void Start()
	{
        addLetter();
        addLetter();
        addLetter();
	}

    public void addLetter() {
        Letter letter = new Letter(LetterGenerator.GetRandomWord(), letterSpawner.SpawnLetter());
        Debug.Log(letter.letter);

        letters.Add(letter);
    }
}
