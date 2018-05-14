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
    public int letterCounter = 0;

    private Transform transformation;
    // Use this for initialization
    void Start () {
        //        letters = gameObject.GetComponent<Text>();
        this.text = "";
        int amount = manager.GetComponent<MatchManager>().wordSize;
        spawnBoxes(amount);
        Transform transformation = this.transform;
	}

    public void appendText (string letter) {
        foreach (Transform child in transform)
        {
            if (child.gameObject.GetComponentInChildren<boxScript>().id == letterCounter)
            {
                this.text += letter;
                child.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = letter;
                this.letterCounter++;
            }
        }
    }
     public void wipeText()
    {
        TMPro.TextMeshProUGUI text = gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        text.text = "";
    }

    public void spawnBoxes(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            float offset = 8.0f / amount;
            GameObject spawnedBox = Instantiate(box);
            spawnedBox.transform.position = new Vector2((boxSize + 1) * i - offset, transform.position.y);
            spawnedBox.GetComponent<boxScript>().id = i;
        }
    }
}
