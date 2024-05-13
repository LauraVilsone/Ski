using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnockback : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    
    private void OnEnable()
    {
        PlayerEvents.OnPlayerHit += GetHit;
    }
    
    private void OnDisable()
    {
        PlayerEvents.OnPlayerHit -= GetHit;
    }

    public void GetHit()
    {
        m_Rigidbody.velocity = Vector3.zero;
        m_Rigidbody.AddForce(transform.forward * -500);
        m_Rigidbody.AddForce(transform.up * +500);
        Debug.Log("Knockback");
    }
}
