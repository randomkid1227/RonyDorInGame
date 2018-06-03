using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTextButtonScript : MonoBehaviour {

    public GameObject answerBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {
                answerBox.GetComponent<AnswerBox>().wipeText();
            }
        }
	}
}
