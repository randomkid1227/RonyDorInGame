using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour {
    private bool tapped;
    private float xStart;
    private float yStart;
    Rigidbody2D rb;
    GameObject matchManager;

    // Use this for initialization
    void Start () {
        matchManager = GameObject.FindGameObjectWithTag("MatchManager");
        rb = GetComponent<Rigidbody2D>();
        tapped = false;
    }
	
	// Update is called once per frame
	void Update () {
        CheckMouse();
        CheckTouch();
		if (tapped)
        {
            tapped = false;
            clicked();
        }
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


                        // get the offset between position you touhes
                        // and the center of the game object
                        xStart = touchPos.x;
                        yStart = touchPos.y;
                    }
                    break;


                // you release your finger
                case TouchPhase.Ended:
                    float xDistance = Mathf.Abs(touchPos.x - xStart);
                    float yDistance = Mathf.Abs(touchPos.y - yStart);

                    float distance = Mathf.Sqrt(xDistance * xDistance + yDistance * yDistance);
                    Debug.Log(distance);
                    if (distance < 0.1)
                    {
                        tapped = true;
                        xStart = 20.0f;
                        yStart = 20.0f;
                    }
                    // restore initial parameters
                    // when thouch is ended
                    if (tapped)
                    {
                        this.rb.gravityScale = 1;
                        //Destroy(this.gameObject); // Should be bubble;
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
