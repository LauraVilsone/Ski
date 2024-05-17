using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public GameObject confetti;
    public delegate void startRaceAction();
    public delegate void stopRaceAction();
    public delegate void retryRaceAction();
    public delegate void nextLevelAction();
    public delegate void quitGameActionAction();

    public static event startRaceAction OnRaceStart;
    public static event stopRaceAction OnRaceStop;

    public static event retryRaceAction OnRaceRetry;
    public static event nextLevelAction OnRaceNext;
    public static event quitGameActionAction OnQuitGame;




    public void RetryRace()
    {
        Debug.Log("Retry race!!");
        if (OnRaceRetry != null)
        {
            OnRaceRetry();
        }
    }


    public void NextRace()
    {
        Debug.Log("next race!!");
        if (OnRaceNext != null)
        {
            OnRaceNext();
        }
    }

    public void QuitGame()
    {
        Debug.Log("quitGame!!");
        if (OnQuitGame != null)
        {
            OnQuitGame();
        }
    }





    public static void StartRace()
    {
        Debug.Log("Start race!!");
        if (OnRaceStart != null)
        {
            OnRaceStart();
        }
    }

    public static void StopRace()
    {
        Debug.Log("Stop race!!");
        //Instantiate(confetti, new Vector3(0 * 2.0f, 0, 0), Quaternion.identity);
        if (OnRaceStop != null)
        {
            OnRaceStop();
        }
    }
}