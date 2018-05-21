using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour {
    public int id;
    private TMPro.TextMeshProUGUI boxText;

    // Use this for initialization
    void Start () {
        this.boxText = gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>();
	}
	
}
