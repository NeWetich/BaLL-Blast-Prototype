using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [HideInInspector] public SaveData saveData;
    [HideInInspector] public BossFight bossFight;
    [HideInInspector] public RegularLevel regularLevel;

    public string linkUiText;

    public int currentLevel
    {
        get { return saveData.currentLevel; }
        set 
        {
            saveData.currentLevel = value;
            linkUiText = value.ToString(); //вместо value поставить UI
        }
    }

    public void LevelStart()
    {
        if (saveData.currentLevel % 5 == 0)
        {
            bossFight.BossLevelStart(); //ссылка
        }
        else
        {
            regularLevel.RegularLevelStart(); //ссылка
        }
    }

}
