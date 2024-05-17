using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    public GameObject confetti;
	public PlayerMovement playerMovement;
	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameEvents.StopRace();
			Instantiate(confetti, other.transform.position, Quaternion.identity);
			playerMovement.m_Animator.Play("Land");
		}
    }
}