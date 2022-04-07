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


    public void RegularLevelStart()
    {
        ballSpawner.BallSpawnerStart();
        UpdateUI();
        LevelBarChange();
        CheckOnVictory();
    }
    public void CheckOnVictory()
    {
        if (ballSpawner.correntballCount == 0)
        {
            if (ballSpawner.ballCountonScene == 0)
            {
                levelComplete.LevelVictory();
            }
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
    protected void UpdateUI()
    {
        textScore.text = BallSpawner.Instance.score.ToString();
    }
    public void LevelBarChange()
    {
        linkScrollbar.size = (float)ballSpawner.ballsCount / maxBallCount;
    }
}
