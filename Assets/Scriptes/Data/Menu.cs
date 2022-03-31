using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Level level;
    public void  ShowSettings()
    {
        //obj.SetActive(true);
    }

    public void HideSettings()
    {
        //obj.SetActive(false);
    }

    public void Start()
    {
        //загрузка сохранения
    }

    public void GameStart()
    {
        //метод скрытия меню
        level.LevelStart();
    }
}
