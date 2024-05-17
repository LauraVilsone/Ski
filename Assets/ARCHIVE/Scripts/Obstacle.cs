using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public PlayerMovement playerMovement;

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitPlayer(collision.gameObject);
			playerMovement.m_Animator.Play("Get Hit");
		}
    }

    public virtual void hitPlayer(GameObject player)
    {
        Debug.Log("HIT BY PLAYERRR");
        PlayerEvents.PlayerGoHit();
    }
}