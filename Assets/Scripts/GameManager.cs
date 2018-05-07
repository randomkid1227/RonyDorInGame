using System.Collections; using System.Collections.Generic; using UnityEngine;  public class GameManager : MonoBehaviour {      public int score;     public float time = 120;     public string current_category;     public static GameManager instance = null;      private void Awake()     {         if (instance == null)             instance = this;         else if (instance == this)             Destroy(gameObject);         DontDestroyOnLoad(gameObject);     }   // Use this for initialization     void Start ()
    {         this.score = 0;     }

    // Update is called once per frame
    void Update () {
        Debug.Log(current_category);
        if (time <= 0)         {             return; // Lose game         }     } }  