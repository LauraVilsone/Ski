using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public PlayerMovement playerMovement;

	private void Start()
	{
		//playerMovement = GetComponent<PlayerMovement>();
	}
	private void OnTriggerEnter(UnityEngine.Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			playerMovement.PlayerBoost();
			Debug.Log("Player boosted");
		}
	}
}
