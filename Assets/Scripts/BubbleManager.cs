using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManager : MonoBehaviour {

    public float bubbleDuration = 3f;
    public float speedMax = 1f;
    public float speedMin = -1f;
    private float spawnTime;
    private float currentTime;
    private float lastUpdateTime;
    public float wiggleInterval = 0.5f;
    private float xC, yC;
    void Start ()
    {
        xC = getRange();
        yC = getRange();
        spawnTime = Time.time;
        lastUpdateTime = Time.time;
    }

	// Update is called once per frame
	void Update ()
    {
        this.currentTime = Time.time;
        if (currentTime - spawnTime >= bubbleDuration) Destroy(gameObject);
        //transform.Translate(xC * Time.deltaTime, yC * Time.deltaTime, 0); // Moves the bubble
        //if (gameObject.transform.position.y <= -7f) Destroy(gameObject);
    }

    float getRange()
    {
        return Random.Range(speedMin, speedMax);
    }

    void Move()
    {
        this.currentTime = Time.time;
        if (currentTime - spawnTime >= bubbleDuration) Destroy(gameObject);
        float speed = Random.Range(speedMin, speedMax);
        if (Time.time - lastUpdateTime > wiggleInterval)
        {
            xC = getRange(); yC = getRange();
            lastUpdateTime = Time.time;
        }
        transform.Translate(xC * Time.deltaTime, yC * Time.deltaTime, 0); // Moves the bubble
    }
}

