using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tappable : MonoBehaviour
{

    // touch offset allows ball not to shake when it starts moving
    float deltaX, deltaY, xStart,yStart;
    GameObject spriteImage;
    Animator animator;

    // reference to Rigidbody2D component
    Rigidbody2D rb;

    // Was the letter tapped?
    public bool tapped;    
    // Use this for initialization
    void Start()
    {
        tapped = false;
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckMouse();
        CheckTouch();
        if (tapped)
        {
            tapped = false;

            gameObject.GetComponentInChildren<LetterDisplay>().SendLetter();
            animator.SetInteger("State", 2);
            Destroy(gameObject, 2);

            //Destroy(this.gameObject); // Should be bubble;
        }
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
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
            //Debug.Log(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position));
            
            // get touch to take a deal with
            Touch touch = Input.GetTouch(0);
            Debug.Log("Tocuhed");

            // obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            // processing touch phases
            switch (touch.phase)
            {

                // if you touches the screen
                case TouchPhase.Began:

                    // if you touch the ball
                    Debug.Log(touchPos);
                    if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(touch.position)))
                    {


                        // get the offset between position you touhes
                        // and the center of the game object
                        tapped = true;
                    }
                    break;


                // you release your finger
                case TouchPhase.Ended:
                    float xDistance = Mathf.Abs(touchPos.x - xStart);
                    float yDistance = Mathf.Abs(touchPos.y - yStart);
               
                    float distance = Mathf.Sqrt(xDistance * xDistance + yDistance * yDistance);
                    Debug.Log(distance);
                    //if (distance < 0.1)
                    //{
                    //    tapped = true;
                    //    xStart = 20.0f;
                    //    yStart = 20.0f;
                    //}
                    //// restore initial parameters
                    // when thouch is ended
                   
                    break;
            }

        }
    }

}