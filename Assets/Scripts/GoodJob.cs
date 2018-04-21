using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodJob : MonoBehaviour {
    private float time;
	// Use this for initialization
	void Start ()
    {
        time = Time.time;
	}
    void Update()
    {
        if (Time.time >= this.time+5f)
        {
            Destroy(gameObject);
        }
    }
}
