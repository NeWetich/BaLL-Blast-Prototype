using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegularLevel : MonoBehaviour
{
    public SaveData saveData;
    public BossFight bossFight;
    public BallSpawner ballSpawner;
    public Scrollbar linkScrollbar;
    public int maxBallCount = 20;

    public void RegularLevelStart()
    {
        ballSpawner.BallSpawnerStart();
        LevelBarChange();
    }

    public void LevelBarChange()
    {
        linkScrollbar.size = (float)maxBallCount / ballSpawner.ballsCount;
    }
}
