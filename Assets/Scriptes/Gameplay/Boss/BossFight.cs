using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BossFight : MonoBehaviour
{
    public Rigidbody2D rb;
    [HideInInspector] public int health = 100;
    [HideInInspector] public int healthMax = 100;
    public TMP_Text textScore;
    [HideInInspector] public GameOver gameOver;
    [HideInInspector] public LevelComplete levelComplete;
    [HideInInspector] public Resource resource;
    [HideInInspector] public SaveData saveData;
  
    [HideInInspector] public int bossBevaivor;
    [HideInInspector] public Vector2 direction;
    [HideInInspector] public float speed = 0.01f;

    public Scrollbar linkScrollbar;
    public BossFly linkBossFly;

    private int score = 0;
    public void BossLevelStart()
    {
        BossBevaivor();
        LevelBarChange();
    }

    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
        if (transform.position.y < 1 && transform.position.x < 1)
        {

        }
    } //сделать

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("character"))
        {
            //gameOver.LevelFailed(); //ссылка
            Debug.Log("gameover");
        }

        if (other.tag.Equals("bullet"))
        {
            TakeDamage(1);
            Bullet.DestroyBullet(other.gameObject);
        }
    }
    public void HpChange()
    {

    }
    public void BossBevaivor()
    {
        bossBevaivor = Random.Range(1, 5);
        if (bossBevaivor == 1)
        {
            linkBossFly.currentPath = 0;
        }
        else if (bossBevaivor == 2)
        {
            linkBossFly.currentPath = 1;
        }
        else if (bossBevaivor == 3)
        {
            linkBossFly.currentPath = 0;
        }
        else if (bossBevaivor == 4)
        {
            linkBossFly.currentPath = 1;
        }

    }

    public void LevelBarChange()
    {
        linkScrollbar.size = (float)health / healthMax;
    }

    public void TakeDamage(int damage)
    {
        if (health > 1)
        {
            health -= damage;
            ++score;
            //score = (saveData.currentLevel * score) * (3 / 2);
        }
        else if (health >= 0)
        {
            Die();
        }
        UpdateScoreUI();
        LevelBarChange();
    }
    virtual protected void Die()
    {
        Destroy(gameObject);
        //resource.TakeResources(); //ссылка
        levelComplete.LevelVictory();
    }

    protected void UpdateScoreUI()
    {
        textScore.text = score.ToString();
    }
}
