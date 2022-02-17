using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	[SerializeField] GameObject[] ballPrefabs;
	[SerializeField] int ballsCount;
	[SerializeField] float spawnDelay;

	GameObject[] balls;

	#region Singleton class: BallSpawner

	public static BallSpawner Instance;

	void Awake()
	{
		Instance = this;
	}

	#endregion

	void Start()
	{
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
