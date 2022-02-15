using UnityEngine;

public class Game : MonoBehaviour
{
	[HideInInspector] public float screenWidth;

	#region Singleton class: Game

	public static Game Instance;

	void Awake()
	{
		Instance = this;
		screenWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
	}

	#endregion

}
