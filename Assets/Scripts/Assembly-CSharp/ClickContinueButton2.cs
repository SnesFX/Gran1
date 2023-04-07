using System;
using UnityEngine;

[Serializable]
public class ClickContinueButton2 : MonoBehaviour
{
	public GameObject LoadingScreen;

	public GameObject allButtons;

	public GameObject ljudHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touch.position))
			{
				LoadingScreen.SetActive(value: true);
				allButtons.SetActive(value: false);
				((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
			}
		}
	}
}
