using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBehavior : MonoBehaviour {
    public float minY = -6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        dropped();
	}
    // If we popped and the letter left the camera (screen);
    void dropped()
    {
        if (this.transform.position.y < minY)
        {
            //Enter logic to add the letter to the word panel;
            Destroy(this.gameObject);
        }
    }
}
