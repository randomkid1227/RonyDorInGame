using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.SceneManagement;
  public class GameManager : MonoBehaviour {      public int score;     public float time;     public float AdditionalWinningTime;
    public string current_category;
    public List<string> found_words = new List<string>();
    public int level = 1;

    public static GameManager instance = null;

    private bool run = false;      private void Awake()     {         if (instance == null)             instance = this;         else if (instance == this)             Destroy(gameObject);         DontDestroyOnLoad(gameObject);     }   // Use this for initialization     void Start ()
    {         this.time = 120f;         this.score = 0;     }

    void Update () {
        timer();      } 
    void timer()
    {
        if (run)
        {
            this.time -= Time.deltaTime;
            if (this.time <= 0)
            {
                stopTimer();
                SceneManager.LoadScene(4);
            }
        }
    }

    // updates the score
    public void addScore(int amount)
    {
        this.score += amount;
    }

    //Add time
    public void addTime() {
        this.time += AdditionalWinningTime;
    }

    // Start and stop timer are public and can be called from any script as long as GameManager exists.
    public void startTimer() { this.run = true; }
    public void stopTimer() { this.run = false; } } 