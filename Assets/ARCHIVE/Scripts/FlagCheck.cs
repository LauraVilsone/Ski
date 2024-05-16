using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCheck : MonoBehaviour
{
    public enum Direction {Left, Right}

    public Material successMaterial;
    public Material failedMaterial;

    public Direction passDirection;


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (passDirection == Direction.Right)
            {

                if (other.transform.position.x > transform.position.x)
                {
                    PassedSuccessful();
                }
                else
                {
                    PassedFailed();
                }

            }
            if (passDirection == Direction.Left)
            {

                if (other.transform.position.x < transform.position.x)
                {
                    PassedSuccessful();
                }
                else
                {
                    PassedFailed();
                }
            }
        }
    }

    void PassedSuccessful()
    {
        Debug.Log("Success");
//mark flag GREEN
        gameObject.GetComponent<MeshRenderer>().material = successMaterial;
    }
    void PassedFailed()
    {
        Debug.Log("Failed");
//mark flag RED
//Add 1 second
        gameObject.GetComponent<MeshRenderer>().material = failedMaterial;

        RaceTimer.penaltySeconds += 1;
    }

}