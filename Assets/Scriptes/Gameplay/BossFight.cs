using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossFight : MonoBehaviour
{
    public class Random
    {
        internal int Next(int v1, int v2)
        {
            throw new System.NotImplementedException();
        }
    }

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
        if (transform)// transform.position == , transform.rotation ==
        {

        }
    }

    public void BossBevaivor()
    {
        Random bevaivor = new Random();
        bossBevaivor = bevaivor.Next(1, 3);
        if (bossBevaivor == 1)
        {

        }
        else if (bossBevaivor == 2)
        {

        }
        else if (bossBevaivor == 3)
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
