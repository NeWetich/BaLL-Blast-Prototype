using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegularLevel : MonoBehaviour
{
    [HideInInspector] public SaveData saveData;
    [HideInInspector] public BossFight bossFight;
    public BallSpawner ballSpawner;
    public Scrollbar linkScrollbar;
    [HideInInspector] public LevelComplete levelComplete;
    [HideInInspector] public int maxBallCount = 5;

    public void Start()
    {
        ballSpawner.BallSpawnerStart();
        LevelBarChange();
        if (ballSpawner.ballsCount == 0) //???
        {
            levelComplete.LevelVictory();
        }
    }
    public void RegularLevelStart()
    {
        ballSpawner.BallSpawnerStart();
        LevelBarChange();
        if (ballSpawner.ballsCount == 0)
        {
            levelComplete.LevelVictory();
        }
    }
    public void LevelBarChange()
    {
        linkScrollbar.size = (float)ballSpawner.ballsCount / maxBallCount;
    }
}
