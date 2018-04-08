using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    // Use this for initialization
    GameObject Manager;

	void Start () {
        Manager = GameObject.FindGameObjectWithTag("Manager");
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "basket")
        {
            Manager.GetComponent<poopLevelManager>().numberOfItems -= 1;
            Debug.Log("Hi");
            Destroy(this.gameObject);
        }
    }
}
