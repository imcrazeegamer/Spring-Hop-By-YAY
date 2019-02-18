using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text ScoreText;
    public int scoreMultiplyer = 100;

    private int score;

    public ScoreManager()
    {
        score = 0;
    }

    public void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        ScoreText.text = "Score: " + score;
    }

    public void PlatformScore(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score += scoreMultiplyer;
            TextUpdate();
        }
        
    }

    private void TextUpdate()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        ScoreText.text = "Score: " + score;

    }


}
