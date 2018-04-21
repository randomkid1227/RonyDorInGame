 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour {

    public GameObject LetterPrefub;

    public LetterDisplay SpawnLetter()
    {
        Vector2 vector = new Vector2(Random.Range(-9f, 9f), 7f);
        GameObject letterObject = Instantiate(LetterPrefub, vector, Quaternion.identity);
        LetterDisplay letterDisplay = letterObject.GetComponentInChildren<LetterDisplay>();
        return letterDisplay;
    }
}
