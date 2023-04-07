using UnityEngine;

public class setGameQuality : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetInt("graphSettings") == 0)
		{
			QualitySettings.SetQualityLevel(0, applyExpensiveChanges: true);
		}
		else if (PlayerPrefs.GetInt("graphSettings") == 1)
		{
			QualitySettings.SetQualityLevel(1, applyExpensiveChanges: true);
		}
		else if (PlayerPrefs.GetInt("graphSettings") == 2)
		{
			QualitySettings.SetQualityLevel(2, applyExpensiveChanges: true);
		}
	}
}
