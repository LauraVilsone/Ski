using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform player;
	// Start is called before the first frame update
	void Update()
	{
		transform.position = player.transform.position + new Vector3(0, 17, 41);
	}
}
