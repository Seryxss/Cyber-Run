using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    private Score scoremanager;
    public GameObject PauseMenus;

    // Update is called once per frame
    void Start()
    {
        scoremanager = FindObjectOfType<Score>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        scoremanager.scoreIncreasing = true;
        PauseMenus.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        
    }

    void Pause()
    {
        scoremanager.scoreIncreasing = false;
        PauseMenus.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
