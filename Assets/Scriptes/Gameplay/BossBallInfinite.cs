using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBallInfinite : MonoBehaviour
{
	[SerializeField] GameObject[] ballPrefabs;
	[SerializeField] int ballsCount;
	[SerializeField] float spawnDelay;

	GameObject[] balls;

	#region Singleton class: BallSpawner

	public static BossBallInfinite Instance;

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
		
	}

}