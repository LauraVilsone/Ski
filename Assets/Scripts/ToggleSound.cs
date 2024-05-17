using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
	public GameObject music;
   public void ToggleMusic()
	{
		music.SetActive(!music.activeInHierarchy);
	}
}
