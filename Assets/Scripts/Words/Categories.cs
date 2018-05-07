using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Categories : MonoBehaviour {

    public Dictionary<string, string[]> myDict;
    // cities, fruits and vegt
    string[] categories = { "ערים", "פירות וירקות", "חיות", "מדינות" };
    public string[] display_categories;
    // Use this for initialization
    void Start () {
        string[] cities = { "לוד", "משהו" };
        string[] world = { "World" };  
        myDict = new Dictionary<string, string[]> { { "ערים", cities }, { "Hello", world } };
        display_categories = get3Categories();
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

    public string[] get3Categories()
    {
        int x1 = Random.Range(0, categories.Length);
        int x2 = Random.Range(0, categories.Length);
        while (x1 == x2)
        {
            x2 = Random.Range(0, categories.Length);
        }
        int x3 = Random.Range(0, categories.Length);
        while (x3 == x2 || x3 == x1)
        {
            x3 = Random.Range(0, categories.Length);
        }

        string[] chosen_categories = new string[3];
        chosen_categories[0] = this.categories[x1];
        chosen_categories[1] = this.categories[x2];
        chosen_categories[2] = this.categories[x3];
        return chosen_categories;
    }

}
