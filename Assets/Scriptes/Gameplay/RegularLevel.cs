using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegularLevel : MonoBehaviour
{
    public GameOver gameOver;
    public Resource resource;
    public BallSpawner ballSpawner;
    public Scrollbar linkScrollbar;
    public LevelComplete levelComplete;
    [HideInInspector] public int maxBallCount = 5;

    public TMP_Text textScore;

    private int score = 0;
    public void RegularLevelStart()
    {
        ballSpawner.BallSpawnerStart();
        LevelBarChange();
        if (ballSpawner.ballsCount == 0)
        {
            levelComplete.LevelVictory();
        }
    }

    void Failed()//условие проигрыша
    {
        gameOver.LevelFailed();
    }
    void Resources()//условие уничтожения обьекта
    {
        resource.TakeResources();
    }

    void ScoreChange()//условие получения урона
    {
        ++score;
        score = (/*SaveData.link.currentLevel * */score) * (3 / 2);
    }
    protected void UpdateUI()
    {
        textScore.text = score.ToString();
    }
    public void LevelBarChange()
    {
        linkScrollbar.size = (float)ballSpawner.ballsCount / maxBallCount;
    }
}
