using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour {

    public GameObject WinText;
    public GameObject AnswerBox;
    public Transform canvas;
    public string chosenCategory;
    public int score = 0;

    private string submittedString;

    bool submitted;
    string[] cities = { "לוד", "תל אביב", "הרצליה", "רחובות", "אילת", "רמלה", "רעננה", "נתניה", "חיפה" };

	// Use this for initialization
	void Start () {
        submitted = false;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (submitted)
        {
            won();
        }
	}

    private bool checkCategoryCity() //Currently only cities, need more categories
    {
        // As there are no 2 letter words if submitted less than 2 letters, return no match.
        if (submittedString.Length <= 2)
        {
            submitted = false;
            return false;
        }
    
        string word;
        int counter = 0;
        int wordLength = submittedString.Length;

        for (int i = 0; i < cities.Length; i++)
        {
            word = cities[i];
            // Checks if we should check the word based on its length.
            if (wordLength == cities[i].Length)
            {
                // Compares user input letters to letters of list items
                // Can improve efficiency
                for(int j = 0; j < submittedString.Length; j++)
                {
                    for(int k = 0; k < submittedString.Length; k++)
                    {
                        // If the letter matches, stop and try to match the next letter.
                        if(word.ToCharArray()[k] == submittedString.ToCharArray()[j])
                        {
                            counter++;
                            break;
                        }
                    }
                }
                if (counter == wordLength)
                {
                    submitted = false;
                    return true;
                }
                // Restart counter if word doesn't match
                counter = 0;
            }
        }
        submitted = false;
        submittedString = "";
        return false;
    }
    public void setSubmitTrue()
    {
        this.submitted = true;
        this.submittedString = AnswerBox.GetComponentInChildren<AnswerBox>().letters.text;
        Debug.Log("Input is " + this.submittedString);
        AnswerBox.GetComponent<AnswerBox>().wipeText();
    }

    private void won()
    {
        if (checkCategoryCity())
        {
            Debug.Log("WON!");
            Instantiate(WinText, canvas);
            score += 100;
        }
        else score -= 20;
    }


}
