using UnityEngine;

public class BallFissionable : Ball
{
    public GameObject[] splitsPrefabs;

    override protected void Die()
    {
        SplitBall();
        --BallSpawner.Instance.ballCountonScene;
        Destroy(gameObject);
        BallSpawner.Instance.score += 50;
    }

    void SplitBall()
    {
        GameObject g;
        for (int i = 0; i < 2; i++)
        {
            ++BallSpawner.Instance.ballCountonScene;
            g = Instantiate(splitsPrefabs[i], transform.position, Quaternion.identity, BallSpawner.Instance.transform);
            g.GetComponent<Rigidbody2D>().velocity = new Vector2(leftAndRight[i], 5f);
        }
    }

}
