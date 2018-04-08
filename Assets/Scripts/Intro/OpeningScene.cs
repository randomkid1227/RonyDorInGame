using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningScene : MonoBehaviour {

    public int HP;
    public float Time;
    public int Score;
    public int Levels;
    public int Screens;

	// Use this for initialization
	void Start () {
        GlobalControl.Instance.DontLoad = new int[] {4, 5};
        GlobalControl.Instance.Load = new int[] { 3 };
        GlobalControl.Instance.HP = HP;
        GlobalControl.Instance.Score = Score;
        GlobalControl.Instance.Levels = Levels;
	}

	//private void Awake()
	//{
 //       // Intilialize the Load Array
 //       int[] LoadArr = GlobalControl.Instance.Load;
 //       LoadArr = new int[Levels - 2];
 //       int x = Levels + Screens;
 //       for (int i = Screens; i < (x - 2); i++) {
 //           if (i != 0 && i != 2) {
 //               LoadArr[i - Screens] = i;
 //           }
 //       }
	//}
}
