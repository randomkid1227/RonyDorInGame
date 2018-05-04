using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{

    public float HP;
    public float Time;
    public float Score;

    void Start()
    {
        HP = GlobalControl.Instance.HP - 1;
        Time = GlobalControl.Instance.Time;
        Score = GlobalControl.Instance.Score;
    }

}
