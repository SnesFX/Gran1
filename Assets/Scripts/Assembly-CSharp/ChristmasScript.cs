using UnityEngine;

public class ChristmasScript : MonoBehaviour
{
	public GameObject ChristmasHolder;

	public bool itsChristmas;

	public GameObject[] christmasStuff;

	private void Start()
	{
		ChristmasHolder = GameObject.Find("ItsTimeForChristmas");
		if (((ItsTimeForChristmas)ChristmasHolder.GetComponent(typeof(ItsTimeForChristmas))).itIsChristmas)
		{
			itsChristmas = true;
		}
		if (itsChristmas)
		{
			GameObject[] array = christmasStuff;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(value: true);
			}
		}
	}
}
