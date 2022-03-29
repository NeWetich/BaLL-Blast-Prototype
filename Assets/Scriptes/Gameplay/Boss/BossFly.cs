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

    public List<Path> paths;

    int currentIndex = 0;
    public int currentPath = 0;

    public Transform GetNext()
    {
        currentIndex++;
        if (currentIndex >= paths[currentPath].PathElements.Length)
            currentIndex = 0;

        return paths[currentPath].PathElements[currentIndex];

    }

}
