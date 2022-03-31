using UnityEngine;
using System.Collections.Generic;

public class SaveLoad : MonoBehaviour
{
    void OnApplicationQuit()
    {
        SaveController.Save(SaveData.link);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void OnBeforeSceneLoadRuntimeMethod()
    {
        SaveController.Load<SaveData>();
    }
}

public class SaveData
{
    public static SaveData link;

    public List<Achievement> achievavements = new List<Achievement>();
    public List<CharacterParameters> characterParameters = new List<CharacterParameters>();
    public MenuSettings menuSettings;
    public Resources resources;

    public int currentLevel = 1;
    public float bestResult = 0;
}

public class CharacterParameters
{
    public int speedFire = 1;
    public float bulletsPower = 0.1f;
    public float money = 0.1f;
    public float offlineMoney = 0.1f;
}
public class MenuSettings
{
    public int Sound = 100;
    public int Music = 100;
    public int Language = 0;
}
public class Achievement
{
    public string Name;
    public bool status = false;
}

public class Resources
{
    public int money;
    public int crystal;
}

