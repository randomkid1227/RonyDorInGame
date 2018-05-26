using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchManager : MonoBehaviour {

    public GameObject WinText;
    public GameObject AnswerBox;
    public Transform canvas;
    public float AdditionalWinningTime;
    public string[] chosenCategory;
    public int score = 0;
    public int wordSize;
    private string submittedString;
    public int scoreToAddOnWin;
    public int scoreToRemoveOnLose;
    private string wordFound;

    bool submitted;
    
	// Use this for initialization
	void Start () {
        submitted = false;
        score = 0;
        // Change the chosen category.
        this.chosenCategory = gameObject.GetComponent<Categories>().getCategory(GameManager.instance.current_category);
        int randomIndex = (int) Random.Range(0f, chosenCategory.Length);
        this.wordSize = chosenCategory[randomIndex].Length;
    }

    // Update is called once per frame
    void Update () {
		if (submitted)
        {
            won();
            submitted = false;
        }
	}
        
    private bool checkCategory() //Currently only cities, need more categories
    {

        string word;
        int counter = 0;
        int wordLength = submittedString.Length;

        for (int i = 0; i < chosenCategory.Length; i++)
        {
            word = chosenCategory[i];
            // Checks if we should check the word based on its length.
            if (wordLength == chosenCategory[i].Length)
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
                    wordFound = chosenCategory[i];
                    if (!wasFound())
                    {
                        GameManager.instance.found_words.Add(wordFound);
                        submitted = false;
                        return true;
                    }
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
        this.submittedString = AnswerBox.GetComponent<AnswerBox>().text;
        Debug.Log("Input is " + this.submittedString);
        AnswerBox.GetComponent<AnswerBox>().wipeText();
    }

    private bool wasFound()
    {
        return GameManager.instance.found_words.Contains(wordFound);
    }

    private void won()
    {
        if (checkCategory())
        {
            GameManager.instance.found_words.Add(submittedString);
            GameManager.instance.time += GameManager.instance.AdditionalWinningTime;
            Debug.Log("WON!");
            Instantiate(WinText, canvas);
            GameManager.instance.level += 1;
            GameManager.instance.addScore(scoreToAddOnWin);
            GameManager.instance.stopTimer();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else GameManager.instance.addScore(-1 * scoreToRemoveOnLose);
    }
}
