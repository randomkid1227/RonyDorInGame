 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour {

    public GameObject LetterPrefub;

    public LetterDisplay SpawnLetter()
    {
        GameObject letterObject = Instantiate(LetterPrefub);
        LetterDisplay letterDisplay = letterObject.GetComponentInChildren<LetterDisplay>();

        return letterDisplay;
    }
}
