using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    static public int maxObject = 200;
    static public Queue<GameObject> balls = new Queue<GameObject>();

    public static GameObject FakeInstantiate(GameObject snowBall, Vector3 transformPosition, Quaternion transformRotation)
    {
        if (balls.Count <= maxObject)
        {
            GameObject newGo = Instantiate(snowBall, transformPosition, transformRotation);
            balls.Enqueue(newGo);
            return newGo;
        }
        else
        {
            GameObject oldGo = balls.Dequeue();
            balls.Enqueue(oldGo);
            oldGo.transform.position = transformPosition;
            oldGo.transform.rotation = transformRotation;
            oldGo.GetComponent<Rigidbody>().velocity = Vector3.zero;
            oldGo.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            return oldGo;
        }
    }
}