using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour {
    public int id;
    private bool last = false;
    private TMPro.TextMeshProUGUI boxText;

    // Use this for initialization
    void Start () {
        this.boxText = gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setLast()
    {
        this.last = true;
    }
}
