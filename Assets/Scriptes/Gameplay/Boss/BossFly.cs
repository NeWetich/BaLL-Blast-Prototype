using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Path
{
    public Transform[] PathElements;
}

public class BossFly : MonoBehaviour
{
    //public static bool flystart = false;

    public List<Path> paths;

    int currentIndex = 0;
    int currentPath = 0;

    public Transform GetNext()
    {
        currentIndex++;
        if (currentIndex >= paths[currentPath].PathElements.Length)
            currentIndex = 0;

        return paths[currentPath].PathElements[currentIndex];

    }
    public void Paths()
    {
        currentPath = Random.Range(0, paths.Count);
    }
}
