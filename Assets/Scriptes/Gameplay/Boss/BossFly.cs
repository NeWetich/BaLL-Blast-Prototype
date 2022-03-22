using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Path
{
    public static Transform[] PathElements;
}

public class BossFly : MonoBehaviour
{
    //public static bool flystart = false;

    public List<Path> paths;

    int currentIndex = 0;

    public Transform GetNext()
    {
        currentIndex++;
        if (currentIndex >= Path.PathElements.Length)
            currentIndex = 0;

        return Path.PathElements[currentIndex];

    }

    //public void OnDrawGizmos()
    //{
    //    if (PathElements == null || PathElements.Length < 2)
    //    {
    //        return;
    //    }

    //    for (int i = 1; i < PathElements.Length; i++)
    //    {
    //        Gizmos.DrawLine(PathElements [i - 1].position, PathElements[i].position);
    //    }
    //}

    //public IEnumerator<Transform> GetNextPathPoint()
    //{
    //    if (PathElements == null || PathElements.Length < 1)
    //    {
    //        yield break;
    //    }

    //    while (true)
    //    {
    //        yield return PathElements[moveingTo];

    //        if (PathElements.Length == 1)
    //        {
    //            continue;
    //        }
    //            if (moveingTo <= 0)
    //            {
    //                movementDirection = 1;
    //            }
    //            else if (moveingTo >= PathElements.Length - 1)
    //            {
    //                movementDirection = -1;
    //            }
    //    }
    //}
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
