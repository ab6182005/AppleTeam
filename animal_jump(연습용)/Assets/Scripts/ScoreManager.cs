using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    public void Start()
    {
        scoreText.text = score.ToString();
    }
    public void setScore(int value)
    {
        score += value;
        Showscore();
    }

    public int getScore()
    {
        return score;
    }

    public void Showscore()
    {

        scoreText.text = score.ToString();
        
    }

}
