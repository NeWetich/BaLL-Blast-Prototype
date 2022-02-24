using UnityEngine;
using System.Collections.Generic;
public class SaveData
{
    public static SaveData link;

    public List<Achievavement> achievavements = new List<Achievavement>();
    public List<CharacterParameters> characterParameters = new List<CharacterParameters>();
    public MenuSettings menuSettings;

    public int gameLevel = 1;
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
public class Achievavement
{
    public string Name;
    public bool status = false;
    public Sprite icon;
}

public class gameLevel
{

}
