using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryDisplayScript : MonoBehaviour {

    TMPro.TextMeshProUGUI category;

    // Use this for initialization
    void Start()
    {
        category = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        category.text = GameManager.instance.current_category;
    }
}
