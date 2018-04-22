using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour {

    public List<Letter> letters;
    public LetterSpawner letterSpawner;
    public float spawnSpeed;

    private void Start()
	{

        InvokeRepeating("addLetter", 1f, spawnSpeed);
	}

    public void addLetter() {
        Letter letter = new Letter(LetterGenerator.GetRandomWord(), letterSpawner.SpawnLetter());
        letters.Add(letter);
    }
}
