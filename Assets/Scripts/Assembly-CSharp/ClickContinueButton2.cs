using System;
using UnityEngine;
using UnityEngine.UI;

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
			{
                Vector2 localPoint;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), touch.position, null, out localPoint);
                if (GetComponent<Image>().rectTransform.rect.Contains(localPoint))
				LoadingScreen.SetActive(value: true);
				allButtons.SetActive(value: false);
				((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
			}
		}
	}
}
