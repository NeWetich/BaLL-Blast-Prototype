using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossFight : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public int health;

    public int bossBevaivor;
    [HideInInspector] public Vector2 direction;
    [HideInInspector] public float speed = 0.01f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
        if (transform.position.y < 1 && transform.position.x < 1)
        {

        }
    }

    public void BossBevaivor()
    {
        bossBevaivor = Random.Range(1, 5);
        if (bossBevaivor == 1)
        {

        }
        else if (bossBevaivor == 2)
        {

        }
        else if (bossBevaivor == 3)
        {

        }
        else if (bossBevaivor == 4)
        {

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
    }
    virtual protected void Die()
    {
        Destroy(gameObject);
    }
}
