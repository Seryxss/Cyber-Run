using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text scoreText2;
    public Text hiScoreText;
    public float scoreCount;
    public float hiScoreCount;
    public float pointPerSecond;
    public bool scoreIncreasing;

    // Update is called once per frame

    void Start()
    {
        //if(PlayerPrefs.GetFloat("Highscore") != null)
        //{
        //    hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        //}    
    }

    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointPerSecond + Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            //PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        scoreText.text = "" + Mathf.Round(scoreCount);
        scoreText2.text = "" + Mathf.Round(scoreCount);
        //hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
    }
}
