using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
    //public static bool ballstart = false;

    int ballSpawner = 0;
    public void BallSpawner()
    {
        ballSpawner = Random.Range(0, 3);
    }

}
