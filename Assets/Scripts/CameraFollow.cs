using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform player;
	public int yOffset;
	public int zOffset;
	public Animator cameraAnimator;
	// Start is called before the first frame update
	void Update()
	{
		transform.position = player.transform.position + new Vector3(0, yOffset, zOffset);
	}

	public void CameraShake()
	{
		cameraAnimator.Play("CameraShake");
	}
}
