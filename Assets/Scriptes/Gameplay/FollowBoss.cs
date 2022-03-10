using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBoss : MonoBehaviour
{

    public enum MovementType
    {
        Moveing,
        Lerping
    }

    public MovementType Type = MovementType.Moveing;
    public BossFly MyPath;
    public float speed = 1;
    public float maxDistance = .1f;

    private IEnumerator<Transform> pointInPath;

    void Start()
    {
        pointInPath = MyPath.GetNextPathPoint();

        pointInPath.MoveNext();

        transform.position = pointInPath.Current.position;
    }

    void Update()
    {
        if (Type == MovementType.Moveing)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);
        }

        else if (Type == MovementType.Lerping)
        {
            transform.position = Vector2.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime * speed);
        }

        var distanceSquare = (transform.position = pointInPath.Current.position).sqrMagnitude;
        if(distanceSquare < maxDistance * maxDistance)
        {
            pointInPath.MoveNext();
        }
    }


}
