using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitPlayer(collision.gameObject);
        }
    }

    public virtual void hitPlayer(GameObject player)
    {
        Debug.Log("HIT BY PLAYERRR");
        PlayerEvents.PlayerGoHit();
    }
}