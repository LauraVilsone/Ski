using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoControl : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    
    private void OnEnable()
    {
        PlayerEvents.OnPlayerHit += NoControl;
    }
    
    private void OnDisable()
    {
        PlayerEvents.OnPlayerHit -= NoControl;
    }

    public void NoControl()
    {
        m_Rigidbody.velocity = Vector3.zero;
    }
}
