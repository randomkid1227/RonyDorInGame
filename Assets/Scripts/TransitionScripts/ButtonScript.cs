using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public int mainSceneID = 2;
    public int id;
    string[] categories;
    string value;
    Text buttonText;

    // Use this for initialization
    void Start () {
        buttonText = gameObject.GetComponentInChildren<Text>();
        categories = gameObject.GetComponentInParent<Categories>().display_categories;
        value = categories[this.id];
        buttonText.text = Reverse(value);
    }

    public void buttonClicked()
    {
        GameManager.instance.current_category = this.value;
        GameManager.instance.startTimer();
        SceneManager.LoadScene(2);
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }
}
