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
    public GameOver gameOver;
    public LevelComplete levelComplete;
    public Resource resource;
    public BossBall bossBall;
  
    [HideInInspector] public int bossBevaivor;
    [HideInInspector] public Vector2 direction;
    [HideInInspector] public float speed = 0.01f;

    [SerializeField] GameObject bossPrefab;

    public Scrollbar linkScrollbar;
    public BossFly linkBossFly;

    private int score = 0;
    public void BossLevelStart()
    {
        BossBevaivor();
        PrepareBoss();
        LevelBarChange();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("character"))
        {
            gameOver.LevelFailed();
            Debug.Log("gameover");
        }

        if (other.tag.Equals("bullet"))
        {
            TakeDamage(1);
            Bullet.DestroyBullet(other.gameObject);
        }
    }

    void PrepareBoss()
    {
        bossPrefab.SetActive(true);
    }
    public void HpChange()
    {
        health = 500 * SaveData.link.currentLevel;
    }
    public void BossBevaivor()
    {
        bossBevaivor = Random.Range(1, 3);
        if (bossBevaivor == 1)
        {
            linkBossFly.currentPath = 0;
            bossBall.BallSpawnerStart();

        }
        else if (bossBevaivor == 2)
        {
            linkBossFly.currentPath = 1;
            bossBall.BallSpawnerStart();
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
            score = (/*SaveData.link.currentLevel * */score) * (3 / 2);
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
        resource.TakeResources();
        levelComplete.LevelVictory();
    }

    protected void UpdateScoreUI()
    {
        textScore.text = score.ToString();
    }
}
