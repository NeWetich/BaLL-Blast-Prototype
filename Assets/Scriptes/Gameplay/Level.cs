using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public BossFight bossFight;
    public RegularLevel regularLevel;

    public string linkUiText;

    public int currentLevel
    {
        get { return SaveData.link.currentLevel; }
        set 
        {
            SaveData.link.currentLevel = value;
            linkUiText = value.ToString(); //вместо value поставить UI
        }
    }

    public void LevelStart()
    {

        if (currentLevel % 5 == 0)
        {
            bossFight.BossLevelStart();
        }
        else
        {
            regularLevel.RegularLevelStart();
        }
    }

}
