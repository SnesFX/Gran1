using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DiffEasyTextCheck : MonoBehaviour
{
	public GameObject diffEasyText;

	public GameObject diffHardText;

	public GameObject diffNormalText;

	public GameObject diffExtremeText;

	public GameObject diffPractiseText;

	public Toggle extraLockToggle;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("fogOnExtreme") == 1)
		{
			extraLockToggle.isOn = true;
			extraLockToggle.interactable = false;
		}
		else
		{
			extraLockToggle.interactable = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			diffNormalText.SetActive(value: true);
			diffEasyText.SetActive(value: false);
			diffHardText.SetActive(value: false);
			diffExtremeText.SetActive(value: false);
			diffPractiseText.SetActive(value: false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			diffEasyText.SetActive(value: true);
			diffHardText.SetActive(value: false);
			diffNormalText.SetActive(value: false);
			diffExtremeText.SetActive(value: false);
			diffPractiseText.SetActive(value: false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			diffHardText.SetActive(value: true);
			diffEasyText.SetActive(value: false);
			diffNormalText.SetActive(value: false);
			diffExtremeText.SetActive(value: false);
			diffPractiseText.SetActive(value: false);
			extraLockToggle.interactable = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			diffExtremeText.SetActive(value: true);
			diffHardText.SetActive(value: false);
			diffEasyText.SetActive(value: false);
			diffNormalText.SetActive(value: false);
			diffPractiseText.SetActive(value: false);
			extraLockToggle.isOn = true;
			extraLockToggle.interactable = false;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			diffPractiseText.SetActive(value: true);
			diffExtremeText.SetActive(value: false);
			diffHardText.SetActive(value: false);
			diffEasyText.SetActive(value: false);
			diffNormalText.SetActive(value: false);
			extraLockToggle.interactable = true;
		}
	}
}
