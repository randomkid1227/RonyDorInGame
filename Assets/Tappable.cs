using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tappable : MonoBehaviour
{

    // touch offset allows ball not to shake when it starts moving
    float deltaX, deltaY, xStart,yStart;

    // reference to Rigidbody2D component
    Rigidbody2D rb;

    // ball movement not allowed if you touches not the ball at the first time
    int tapCounter = 0;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckTouch();
        CheckMouse();
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {

                if (tapCounter >= 3) Destroy(this.gameObject);
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
                    if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(touchPos))
                    {


                        // get the offset between position you touhes
                        // and the center of the game object
                        xStart = touchPos.x;
                        yStart = touchPos.y;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
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
                        tapCounter++;
                        xStart = 20.0f;
                        yStart = 20.0f;
                    }
                    // restore initial parameters
                    // when thouch is ended
                    if (tapCounter >= 3) Destroy(this.gameObject);
                    break;
            }

        }
    }
}