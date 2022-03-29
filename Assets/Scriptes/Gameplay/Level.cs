using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public SaveData saveData;
    public BossFight bossFight;
    public RegularLevel regularLevel;

    public void LevelStart()
    {
        if (saveData.currentLevel % 5 == 0)
        {
            bossFight.BossLevelStart();
        }
        else
        {
            regularLevel.RegularLevelStart();
        }
    }

}
