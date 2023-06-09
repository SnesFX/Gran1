using System;
using UnityEngine;

[Serializable]
public class closeOptionMenuIG : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject optionButton;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject bedButtons;

	public GameObject savedValue;

	public GameObject soundHolder;

	public GameObject carControls;

	public virtual void Start()
	{
		_ = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touch.position))
			{
				saveSensitivityData saveSensitivityData2 = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
				Time.timeScale = 1f;
				optionMenu.SetActive(value: false);
				optionButton.SetActive(value: true);
				joystick.SetActive(value: true);
				crouchButton.SetActive(value: true);
				bedButtons.SetActive(value: true);
				carControls.SetActive(value: true);
				PlayerPrefs.SetInt("slideData", (int)saveSensitivityData2.sliderValue);
				((backgroundSound)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
			}
		}
	}
}
