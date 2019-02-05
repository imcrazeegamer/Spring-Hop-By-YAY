using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static ScoreManager scoring;

    void Start()
    {
        scoring = new ScoreManager();  
    }
}
