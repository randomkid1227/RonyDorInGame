using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour {
    private bool tapped;
    private float xStart;
    private float yStart;
    Rigidbody2D rb;
    public GameObject matchManager;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        tapped = false;
    }
	
	// Update is called once per frame
	void Update () {
        CheckMouse();
        CheckTouch();
	}

    void CheckMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {
                tapped = true;
            }
        }
    }
    void CheckTouch()
    {
        // Initiating touch event
        // if touch event takes place
        if (Input.touchCount > 0)
        {

            // get touch to take a deal with
            Touch touch = Input.GetTouch(0);

            // obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            // processing touch phases
            switch (touch.phase)
            {

                // if you touches the screen
                case TouchPhase.Began:

                    // if you touch the ball
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
                    {

                        tapped = true;
                    }
                    break;


                // you release your finger
                case TouchPhase.Ended:
                  if (tapped)
                    {
                        clicked();
                        tapped = false;
                    }
                    break;
            }
        }
    }
    public void clicked()
    {
        matchManager.GetComponent<MatchManager>().setSubmitTrue();
    }
}
