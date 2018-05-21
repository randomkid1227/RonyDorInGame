using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBox : MonoBehaviour {

    public Text letters;
    public string text;
    public GameObject box;
    public GameObject manager;
    public float boxSize;
    private int numletters;
    public int letterCounter = 0;

    private Transform transformation;
    // Use this for initialization
    void Start () {
        //        letters = gameObject.GetComponent<Text>();
        this.text = "";
        numletters = manager.GetComponent<MatchManager>().wordSize;
        spawnBoxes(numletters);
        Transform transformation = this.transform;
	}
    void Update()
    {
        if (letterCounter == numletters)
        {
            manager.GetComponent<MatchManager>().setSubmitTrue();
        }
    }

    public void appendText (string letter) {
        foreach (Transform child in transform)
        {
            if (child.gameObject.GetComponentInChildren<boxScript>().id == letterCounter)
            {
                this.text += letter;
                child.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = letter;
            }
        }
        this.letterCounter++;
    }
     public void wipeText()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
        }
        this.text = "";
        this.letterCounter = 0;
    }
    
    public void spawnBoxes(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            float offset = 2f;
            GameObject spawnedBox = Instantiate(box, this.transform);
            spawnedBox.transform.position = new Vector2(offset - (boxSize+0.7f) * i, transform.position.y);
            spawnedBox.GetComponent<boxScript>().id = i;
        }
    }
}
