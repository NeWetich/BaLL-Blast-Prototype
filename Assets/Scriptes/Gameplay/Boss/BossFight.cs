using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

    public Scrollbar.ScrollEvent size;
    public void LevelBarChanged()
    {
       
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
