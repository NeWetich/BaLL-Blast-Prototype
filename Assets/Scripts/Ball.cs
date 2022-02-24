using UnityEngine;
using TMPro;


public class Ball : MonoBehaviour
{
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private int health;

    [SerializeField] private TMP_Text textHealth;
    [SerializeField] private float jumpForce;

	protected float[] leftAndRight = new float[2] { -1f, 1f };

	[HideInInspector] public bool isResultOfFission = true;

	protected bool isShowing;

	[SerializeField] GameObject coinPrefab;

	void Start()
	{
		UpdateHealthUI();

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
			Debug.Log("gameover");
		}

		if (other.tag.Equals("bullet"))
		{
			TakeDamage(1);
            Bullet.DestroyBullet(other.gameObject);
		}

		if (!isShowing && other.tag.Equals("wall"))
		{
			float posX = transform.position.x;
			if (posX > 0)
			{
				rb.AddForce(Vector2.left * 150f);
			}
			else
			{
				rb.AddForce(Vector2.right * 150f);
			}

			rb.AddTorque(posX * 4f); 
		}

		if (other.tag.Equals("floor"))
		{

			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			rb.AddTorque(-rb.angularVelocity * 4f);
		}
	}

	public void TakeDamage(int damage)
	{
		if (health > 1)
		{
			health -= damage;
		}
		else if (health >= 0)
		{
			Die();
		}
		UpdateHealthUI();
	}

	virtual protected void Die()
	{
		Destroy(gameObject);
		Instantiate(coinPrefab, transform.position, transform.rotation);
    }

	protected void UpdateHealthUI()
	{
        textHealth.text = health.ToString();
    }

}
