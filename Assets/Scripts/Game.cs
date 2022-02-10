using UnityEngine;

public class Game : MonoBehaviour
{
	public static Game Instance;

	public void Awake()
	{
		Instance = this;
		screenWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
	}

	[HideInInspector] public float screenWidth;
}
