using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{

    public bool raceStarted = false;
    public float startTime;
    public static float penaltySeconds = 0;

    void OnEnable()
    {
        GameEvents.OnRaceStart += StartTimer;
        GameEvents.OnRaceStop += StopTimer;
    }
    void OnDisable()
    {
        GameEvents.OnRaceStart -= StartTimer;
        GameEvents.OnRaceStop -= StopTimer;
    }

    void StartTimer()
    {
        penaltySeconds = 0;
        raceStarted = true;
        startTime = Time.time; //12:00
    }


    void StopTimer()
    {
        raceStarted = false;
        float timePlayed = (Time.time - startTime) + penaltySeconds;
        Debug.Log("We played: "+ timePlayed);
    }


}