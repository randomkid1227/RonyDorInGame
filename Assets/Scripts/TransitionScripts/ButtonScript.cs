using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    public int id;
    Text text;
    string[] categories;
    string value;

    // Use this for initialization
    void Start () {
        text = gameObject.GetComponentInChildren<Text>();
        categories = gameObject.GetComponentInParent<Categories>().display_categories;
        value = categories[id - 1];
        text.text = Reverse(value);
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
