using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManager : MonoBehaviour {

    public float speed = 1f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0f, -speed *Time.deltaTime, 0f);
        if (gameObject.transform.position.y <= -7f) Destroy(gameObject);
	}
}
