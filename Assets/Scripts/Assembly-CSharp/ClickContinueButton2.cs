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
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), touch.position, null, out localPoint);
            if (GetComponent<RectTransform>().rect.Contains(localPoint) && touch.phase == TouchPhase.Ended)
            {
                LoadingScreen.SetActive(true);
                allButtons.SetActive(false);
                ((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
            }
        }
    }
}
