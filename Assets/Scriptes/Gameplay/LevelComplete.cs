using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class LevelComplete : MonoBehaviour
{
    public SaveData saveData;
    public Button back;
    public Button next;
    public void LevelVictory()
    {
        //показывает окно со счетом и заработанными монетами
        ++saveData.currentLevel;
        //кнопки либо вернуться в меню, либо продолжить следующий уровень

    }
}
