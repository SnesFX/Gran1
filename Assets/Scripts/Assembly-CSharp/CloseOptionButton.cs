using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CloseOptionButton : MonoBehaviour
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
            Vector2 touchPosition = touch.position;
            if (touch.phase == TouchPhase.Ended && RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), touchPosition, Camera.main))
			{
				optionMenu.SetActive(value: false);
				joystick.SetActive(value: true);
				joystickRing.SetActive(value: true);
				mapButton.SetActive(value: true);
				swordButton.SetActive(value: true);
				allapapperslappar.SetActive(value: true);
				pianoCollider.SetActive(value: true);
				Time.timeScale = 1f;
			}
		}
	}
}
