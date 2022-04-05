using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class LevelComplete : MonoBehaviour
{
    public Button back;
    public Button next;

    public Level level;

    public GameObject layoutLevelComplete;
    public GameObject layoutMenuSettings;
    public GameObject layoutBallSpawner;
    public GameObject layoutCharacterActive;
    public GameObject layoutCharacterMenu;
    public void LevelVictory()
    {
        layoutLevelComplete.gameObject.SetActive(true);
        //++SaveData.link.currentLevel;
        layoutCharacterActive.gameObject.SetActive(false);
        layoutCharacterMenu.gameObject.SetActive(true);
        BackMenu();
        NextLevel();
    }

    public void BackMenu()
    {
        layoutLevelComplete.gameObject.SetActive(false);
        layoutMenuSettings.gameObject.SetActive(true);
        layoutBallSpawner.gameObject.SetActive(false);
    }
    public void NextLevel()
    {
        layoutLevelComplete.gameObject.SetActive(false);
        level.LevelStart();
    }
}
