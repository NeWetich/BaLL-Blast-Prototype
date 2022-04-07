using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public int ballsCount = 5;
	[HideInInspector] float spawnDelay = 4;
	public int correntballCount;
	public int ballCountonScene;
	public int score = 0;

	[SerializeField] GameObject[] ballPrefabs;

	GameObject[] balls;

	#region Singleton class: BallSpawner

	public static BallSpawner Instance;

	void Awake()
	{
		Instance = this;
	}

    #endregion

	public void BallSpawnerStart()
    {
        PrepareBalls();
		StartCoroutine(SpawnBalls());
	}

	IEnumerator SpawnBalls()
	{
		for (int i = 0; i < ballsCount; i++)
		{
			balls[i].SetActive(true);
			--correntballCount;
			++ballCountonScene;
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
