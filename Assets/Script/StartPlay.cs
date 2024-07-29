using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    public GameObject instructionPanel;

    // Update is called once per frame

    private void Start()
    {
        instructionPanel.SetActive(true);
    }

    public void startGame()
    {
        instructionPanel.SetActive(false);
        SceneManager.LoadScene(2);
    }
}
