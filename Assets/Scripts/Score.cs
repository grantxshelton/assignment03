using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

	public static int PinCount;
	public static int Lives = 5;
	public static int NextLife;
	public static int HighScore;

	public Text text;

	void Start()
	{
		PinCount = 0;
		//Lives = NextLife;
	}

	void Update()
	{
		text.text = PinCount.ToString();// Set score text to PinCount
		if (PinCount > HighScore) // Check if the current score is higher than the high score.
		{
			HighScore = PinCount; // Update the high score if necessary.
		}

		if (Lives == 0)
			SceneManager.LoadScene("Credits");
	}

}
