using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class poopLevelManager : MonoBehaviour {
    public GameObject garbage;
    public GameObject poop;
    float startTime;
    float endTime;
    float minX = -5.5f;
    float minY = -4.5f;
    float maxX = 5.5f;
    float maxY = 4.5f;
    public int numberOfItems;


	// Use this for initialization
	void Start () {
        numberOfItems = (int)Random.Range(3f, 5f);
        Debug.Log(numberOfItems);
        startTime = Time.time;
        endTime = startTime + 6f; //Manager.gameObject.levelTime; //TODO: create leveltime in Manager or something...
        for (int i = 0; i < numberOfItems; i++) Invoke("spawnObjects", 0.05f);
        Debug.Log(Time.time);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= endTime)
        {
            LoadByIndex(2); // Lose screen  
        }
        if (numberOfItems <= 0)
        {
            LoadByIndex(1); // Win screen
        }
		
	}
 
    void spawnObjects()
    {
        GameObject poopInstance = Instantiate(poop);
        poopInstance.transform.position = new Vector3( Random.Range(minX, maxX), Random.Range(minY, maxY) );
        Debug.Log("...");
        
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
