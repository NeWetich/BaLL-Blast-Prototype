using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public int ballsCount = 5;
	[HideInInspector] float spawnDelay = 4;
	[HideInInspector] public SaveData saveData;
	[HideInInspector] public Ball ball;

	[SerializeField] GameObject[] ballPrefabs;
	
	GameObject[] balls;

	#region Singleton class: BallSpawner

	public static BallSpawner Instance;

	void Awake()
	{
		Instance = this;
	}

	#endregion

	public void HpBall()
	{
		ball.health = Random.Range(1, 51) * saveData.currentLevel;
	}

    public void BallSpawnerStart()
    {
		//HpBall(); //ссылка
		PrepareBalls();
		StartCoroutine(SpawnBalls());
	}

	IEnumerator SpawnBalls()
	{
		for (int i = 0; i < ballsCount; i++)
		{
			balls[i].SetActive(true);
			yield return new WaitForSeconds(spawnDelay);
		}
	}
	void PrepareBalls()
	{
		balls = new GameObject[ballsCount];
		int prefabsCount = ballPrefabs.Length;
		for (int i = 0; i < ballsCount; i++)
		{
			balls[i] = Instantiate(ballPrefabs[Random.Range(0, prefabsCount)], transform);
			balls[i].GetComponent<Ball>().isResultOfFission = false;
			balls[i].SetActive(false);
		}
	}

}
