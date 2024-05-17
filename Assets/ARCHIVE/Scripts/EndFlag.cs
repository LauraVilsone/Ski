using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    public GameObject confetti;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameEvents.StopRace();
			Instantiate(confetti, other.transform.position, Quaternion.identity);
		}
    }
}