using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PressOptionButton : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject joystick;

	public GameObject joystickRing;

	public GameObject mapButton;

	public GameObject swordButton;

	public GameObject allapapperslappar;

	public GameObject pianoCollider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<RectTransform>().HitTest(touch.position))
			{
				optionMenu.SetActive(value: true);
				joystick.SetActive(value: false);
				joystickRing.SetActive(value: false);
				mapButton.SetActive(value: false);
				swordButton.SetActive(value: false);
				allapapperslappar.SetActive(value: false);
				pianoCollider.SetActive(value: false);
				Time.timeScale = 0f;
			}
		}
	}
}
