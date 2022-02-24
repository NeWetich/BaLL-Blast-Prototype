using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int health;


    void Start()
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
