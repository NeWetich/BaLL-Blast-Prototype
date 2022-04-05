using System.Collections;
using UnityEngine;


public class Resource : MonoBehaviour
{
	public GameObject coinPrefab;
	public GameObject crystalPrefab;

	public Coin coin;
	public Crystal crystal;

	int crystalChange = 2;
	int change;
	public void TakeResources()
	{
		change = Random.Range(1, 101);
		if (change <= crystalChange)
		{
			Instantiate(crystalPrefab, transform.position, transform.rotation);
		}
		else
		{
			Instantiate(coinPrefab, transform.position, transform.rotation);
		}
	}
}
