using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	static Queue<GameObject> bulletQueue;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] int bulletCount;

	[Space]
	[SerializeField] float delay = 0f;
	[SerializeField] float speed = 0f;

	GameObject g;
	float t = 0f;

	#region Singleton class: Bullet

	public static Bullet Instance;

	void Awake()
	{
		Instance = this;
	}

	#endregion

	void Start()
	{
		PrepareBullet();
	}

	void Update()
	{
		t += Time.deltaTime;
		if (t >= delay)
		{
			t = 0f;
			g = SpawnBullet(transform.position);
			if (g != null)
				g.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		}
	}
	void PrepareBullet()
	{
		bulletQueue = new Queue<GameObject>();
		for (int i = 0; i < bulletCount; i++)
		{
			g = Instantiate(bulletPrefab, transform.position, Quaternion.identity, transform);
			g.SetActive(false);
			bulletQueue.Enqueue(g);
		}
	}

	public GameObject SpawnBullet(Vector2 position)
	{

		if (Input.GetMouseButton(0))
        {
            g = bulletQueue.Dequeue();
            g.transform.position = position;
            g.SetActive(true);
            return g;
        }

        return null;
	}
	public static void DestroyBullet(GameObject bullet)
	{
		bulletQueue.Enqueue(bullet);
		bullet.SetActive(false);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.Equals("bullet"))
		{
			DestroyBullet(other.gameObject);
		}
	}

}
