using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.Equals("character"))
		{
			Destroy(gameObject);
		}

	}
}
