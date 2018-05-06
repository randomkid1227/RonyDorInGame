using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Categories : MonoBehaviour {

    public Dictionary<string, string[]> myDict;
    string[] categories;
    // Use this for initialization
    void Start () {
        string[] categories = { "ערים", "פירות וירקות", "חיות", "מדינות" };
        string[] cities = { "לוד", "משהו" };
        string[] world = { "World" };  
        myDict = new Dictionary<string, string[]> { { "ערים", cities }, { "Hello", world } };
    }
	
    public string[] getCategory(string name)
    {
        return myDict[name];
    }

    // Completely random, maybe add logic to not repeat
    public string getRandomCategoryName()
    {
        return categories[Random.Range(0, categories.Length)];
    }

}
