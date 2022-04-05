using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Level level;

    public GameObject layoutMenuSettings;
    public GameObject layoutButtonSettings;
    public GameObject layoutBallSpawner;
    public GameObject layoutCharacterActive;
    public GameObject layoutCharacterMenu;
    public void ShowSettings()
    {
        layoutButtonSettings.gameObject.SetActive(true);
    }

    public void HideSettings()
    {
        layoutButtonSettings.gameObject.SetActive(false);
    }
    public void GameStart()
    {
        layoutBallSpawner.gameObject.SetActive(true);
        layoutCharacterMenu.gameObject.SetActive(false);
        layoutCharacterActive.gameObject.SetActive(true);
        level.LevelStart();
        layoutMenuSettings.gameObject.SetActive(false);
    }

}
