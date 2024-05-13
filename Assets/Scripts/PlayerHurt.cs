using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    public bool hurt;
    public int recoveryTime;

    private void OnEnable()
    {
        PlayerEvents.OnPlayerHit += IsHurt;
    }

    private void OnDisable()
    {
        PlayerEvents.OnPlayerHit -= IsHurt;
    }

    public void IsHurt()
    {
        hurt = true;
        StartCoroutine("Recover");
    }
    
    IEnumerator Recover()
    {
        yield return new WaitForSeconds(recoveryTime);
        hurt = false;
    }
}
