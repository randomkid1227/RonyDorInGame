using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {

    public float HP;
    public float Time;
    public float Score;
    public float changeInLevelTime; // percent
    public float ScoreGain;

	void Start () {
        HP = GlobalControl.Instance.HP;
        Time = GlobalControl.Instance.Time * changeInLevelTime;
        Score = GlobalControl.Instance.Score + ScoreGain;
	}

}
