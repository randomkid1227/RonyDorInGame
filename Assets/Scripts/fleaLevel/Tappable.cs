using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tappable : MonoBehaviour
{

    // touch offset allows ball not to shake when it starts moving
    float deltaX, deltaY;

    // reference to Rigidbody2D component
    Rigidbody2D rb;

    // ball movement not allowed if you touches not the ball at the first time
    bool tapped = false;

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

                tapped = true;
                if (tapped) Destroy(this.gameObject);
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
                        // get the offset between position you touhes
                        // and the center of the game object
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;


                // you release your finger
                case TouchPhase.Ended:

                    // restore initial parameters
                    // when thouch is ended
                    if (tapped) Destroy(this.gameObject);
                    break;
            }

        }
    }
}