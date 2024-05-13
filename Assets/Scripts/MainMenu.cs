using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject question;
    public CanvasGroup menuCanvasGroup;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void PreQuit()
    {
        question.SetActive(true);
        menuCanvasGroup.interactable = false;
    }

    public void YesButton()
    {
        Debug.LogError("Quitting");
        Application.Quit();
    }
    public void NoButton()
    {
        question.SetActive(false);
        menuCanvasGroup.interactable = true;
    }

}