using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;

	private float[] leftAndRight = new float[2] { -1f, 1f };

	[HideInInspector] private bool isResultOfFission = true;

	private bool isShowing;

	void Start()
	{
		isShowing = true;
		rb.gravityScale = 0f;

		if (isResultOfFission)
		{
			FallDown();
		}
		else
		{
			float direction = leftAndRight[Random.Range(0, 2)];
			float screenOffset = Game.Instance.screenWidth * 1.3f;
			transform.position = new Vector2(screenOffset * direction, transform.position.y);

			rb.velocity = new Vector2(-direction, 0f);
			Invoke("FallDown", Random.Range(screenOffset - 2.5f, screenOffset - 1f));
		}

	}

	void FallDown()
	{
		isShowing = false;
		rb.gravityScale = 1f;
		rb.AddTorque(Random.Range(-20f, 20f));
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.Equals("character"))
		{
			Destroy(gameObject);
		}

		if (!isShowing && other.tag.Equals("wall"))
		{
			float posX = transform.position.x;
			if (posX > 0)
			{
				rb.AddForce(Vector2.left);
			}
			else
			{
				rb.AddForce(Vector2.right);
			}

			rb.AddTorque(posX);
		}

		if (other.tag.Equals("floor"))
		{
			rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
			rb.AddTorque(-rb.angularVelocity * 4f);
		}

	}
}
