using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class QuitApp : MonoBehaviour
{
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
            if (touch.phase == TouchPhase.Ended)
            {
                RectTransform rectTransform = GetComponent<RectTransform>();
                if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, touch.position))
                {
				((soundEffectsMenu)ljudHolder.GetComponent(typeof(soundEffectsMenu))).buttonClick();
				Application.Quit();
                }
            }
        }
    }
}