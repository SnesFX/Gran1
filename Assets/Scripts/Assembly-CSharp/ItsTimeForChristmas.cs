using UnityEngine;

public class ItsTimeForChristmas : MonoBehaviour
{
	public bool itIsChristmas;

	private void Awake()
	{
		Object.DontDestroyOnLoad(base.gameObject);
	}
}
