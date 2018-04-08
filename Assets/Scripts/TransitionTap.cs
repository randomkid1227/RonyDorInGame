using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTap : MonoBehaviour {
    
    public int Levels;
    public int[] DontLoad;
    public int[] Load;
	
    void Start()
	{
        DontLoad = GlobalControl.Instance.DontLoad;
        Load = GlobalControl.Instance.Load;
        Levels = GlobalControl.Instance.Levels;
	}

	// Update is called once per frame
	void Update () {
        LoadByTap();
	}

    void LoadByTap () {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
            DontLoad = GlobalControl.Instance.DontLoad;
            Load = GlobalControl.Instance.Load;
            Levels = GlobalControl.Instance.Levels;
            LoadByIndex(NextLevel());
        }
    }

    public void LoadByIndex(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }


    int NextLevel() {

        int random = (int)Mathf.Floor(Random.Range(0, Load.Length));
        int chosen = Load[random];

        Swap(random);

        return chosen;
    }


    void Swap(int level) {
        int temp = Load[level];
        int swap = DontLoad[1];

        Load[level] = swap;
        DontLoad[1] = DontLoad[0];
        DontLoad[0] = temp;
    }

}
