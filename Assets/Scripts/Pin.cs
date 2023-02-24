using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

	private bool isPinned = false;
	private bool lostLife = false;

	public static float speed = 100f;
	public Rigidbody2D rb;

    private void Start()
    {
		Score.NextLife = Score.Lives - 1;
    }
    void Update()
	{
		if (!isPinned)
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Rotator")
		{
			transform.SetParent(col.transform);
			Score.PinCount++;
			isPinned = true;
		}
		else if (col.tag == "Pin" && !lostLife)
		{

			lostLife = true;
			Score.Lives = Score.NextLife;
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
