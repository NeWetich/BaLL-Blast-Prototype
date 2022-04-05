using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBall : MonoBehaviour
{
	public int ballsCount = 10;
	[HideInInspector] float spawnDelay = 8;

	[SerializeField] GameObject[] ballPrefabs;

	GameObject[] balls;


	#region Singleton class: BallSpawner

	public static BossBall Instance;

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
			yield return new WaitForSeconds(spawnDelay);
		}
	}
	void PrepareBalls()
	{
		balls = new GameObject[ballsCount];
		int prefabsCount = ballPrefabs.Length;
		for (int i = 0; i < ballsCount; i++)
		{
			balls[i].GetComponent<Ball>().isResultOfFission = false;
			balls[i].SetActive(false);
		}
	}

}
