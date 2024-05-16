using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameM : MonoBehaviour
{
    public GameObject popup;

    private void OnEnable()
    {
        GameEvents.OnRaceRetry += RaceRetry;
        GameEvents.OnRaceNext += RaceNext;
        GameEvents.OnQuitGame += QuitGame;
        GameEvents.OnRaceStop += ShowPopup;
    }

    private void OnDisable()
    {
        GameEvents.OnRaceRetry -= RaceRetry;
        GameEvents.OnRaceNext -= RaceNext;
        GameEvents.OnQuitGame -= QuitGame;
        GameEvents.OnRaceStop -= ShowPopup;
    }

    void ShowPopup()
    {
        popup.SetActive(true);
    }

    void RaceRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void RaceNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    void QuitGame()
    {
        Debug.LogError("Quitting application");
        Application.Quit();
    }
}