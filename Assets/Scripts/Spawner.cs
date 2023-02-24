using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject pinPrefab;
	public Camera Cam;

	void Update()
	{
        if (!Pause.isPaused) // Checks if game is paused before letting player spawn in a pin
        {
			if (Input.GetButtonDown("Fire1"))
			{
				SpawnPin();
			}
		}
        else
        {
			if (Input.GetButtonDown("Fire1"))
			{
				
			}
		}
		
	}

	void SpawnPin()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
		Cam.GetComponent<AudioSource>().Play();
	}

}
