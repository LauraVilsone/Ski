using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
	public PlayerMovement playerMovement;
    public CameraFollow cameraFollow;
    public Slider healthbar;
    GameObject player;

	private void Start()
	{
        player = GameObject.FindWithTag("Player");
	}

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitPlayer(collision.gameObject);
			playerMovement.m_Animator.Play("Get Hit");
            cameraFollow.CameraShake();
            healthbar.value--;
            Debug.Log(healthbar.value);
            if (healthbar.value == 0)
            {
                player.transform.position = new Vector3(100, 1, -12);
            }
		}
    }

    public virtual void hitPlayer(GameObject player)
    {
        Debug.Log("HIT BY PLAYERRR");
        PlayerEvents.PlayerGoHit();
    }
}