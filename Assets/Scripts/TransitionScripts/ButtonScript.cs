using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour {

    public int mainSceneID = 2;
    public int id;
    string[] categories;
    string value;
    TMPro.TextMeshProUGUI buttonText;


    // Use this for initialization
    void Start () {
        buttonText = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        categories = gameObject.GetComponentInParent<Categories>().display_categories;
        value = categories[this.id];
        buttonText.text = Reverse(value);
    }

    public void buttonClicked()
    {
        GameManager.instance.current_category = this.value;
        GameManager.instance.startTimer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {
                buttonClicked();
                Destroy(this);
            }
        }
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }
}
