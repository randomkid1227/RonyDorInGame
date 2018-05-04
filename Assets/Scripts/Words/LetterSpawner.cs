 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour {

    public GameObject LetterPrefub;

    public LetterDisplay SpawnLetter()
    {
        Vector2 vector = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-6f, 6f));
        GameObject letterObject = Instantiate(LetterPrefub, vector, Quaternion.identity);
        LetterDisplay letterDisplay = letterObject.GetComponentInChildren<LetterDisplay>();
        letterObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        return letterDisplay;
    }
}
