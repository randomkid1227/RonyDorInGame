 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour {

    public GameObject LetterPrefub;

    public LetterDisplay SpawnLetter()
    {
        Vector2 vector = new Vector2(Random.Range(-1.4f, 1.4f), Random.Range(-4f, 1.8f));
        GameObject letterObject = Instantiate(LetterPrefub, vector, Quaternion.identity);
        LetterDisplay letterDisplay = letterObject.GetComponentInChildren<LetterDisplay>();
        letterObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f));
        return letterDisplay;
    }
}
