using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void PressPlay()
    {
        SceneManager.LoadScene("Level");
    }

    //GameObject obj;
    //public void Start()
    //{
    //    obj = GameObject.Find("buttonsSettings");
    //}
    public void  ShowSettings()
    {
        //obj.SetActive(true);
    }

    public void HideSettings()
    {
        //obj.SetActive(false);
    }
}
