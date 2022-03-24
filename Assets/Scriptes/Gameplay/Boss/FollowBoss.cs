using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBoss : MonoBehaviour
{

    public BossFly MyPath;
    [HideInInspector] public float speed = 1;
    [HideInInspector] public float maxDistance = .1f;

    private Transform pointInPath;

    void Start()
    {
        pointInPath = MyPath.GetNext();

        transform.position = pointInPath.position;
    }

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, pointInPath.position, Time.deltaTime * speed);

        var distanceSquare = Vector3.Distance(transform.position, pointInPath.position);

        if(distanceSquare < maxDistance)
        {
            pointInPath = MyPath.GetNext();
        }
    }

}
