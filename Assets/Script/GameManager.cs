using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    //public GameObject gameOverPanel;
    //public GameObject gameWinPanel;
    public GameObject Score1;
    private Score scoremanager;
    AudioSource audiosrc;

    // Update is called once per frame
    [SerializeField] ResultUIManager resultUIManagerScript;


    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        scoremanager = FindObjectOfType<Score>();
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            //gameOverPanel.SetActive(true);
            audiosrc.Stop();
            TriggerGameLose();
            //Time.timeScale = 0;
            scoremanager.scoreIncreasing = false;
            Score1.SetActive(false);
        }
        
        if (scoremanager.scoreCount > 1000)
        {
            //gameWinPanel.SetActive(true);
            TriggerGameWin();
            audiosrc.Stop();
            //Time.timeScale = 0;
            scoremanager.scoreIncreasing = false;
            Score1.SetActive(false);
        }
    }

    public void TriggerGameWin()
    {
        resultUIManagerScript.IsGameWin = true;
        resultUIManagerScript.GameScore = scoremanager.scoreCount;
        resultUIManagerScript.ShowSubmittingUI();
    }

    public void TriggerGameLose()
    {
        resultUIManagerScript.IsGameWin = false;
        resultUIManagerScript.GameScore = scoremanager.scoreCount;
        resultUIManagerScript.ShowSubmittingUI();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        scoremanager.scoreCount = 0;
        scoremanager.scoreIncreasing = true;
    }
}

