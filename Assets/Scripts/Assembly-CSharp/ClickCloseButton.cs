using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickCloseButton : MonoBehaviour
{
    public GameObject OptionsMenu;

    public GameObject MenuButtons;

    public GameObject ljudHolder;

    public virtual void Update()
    {
        Touch[] touches = Input.touches;
        for (int i = 0; i < touches.Length; i++)
        {
            Touch touch = touches[i];
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 localPoint;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), touch.position, null, out localPoint);
                if (GetComponent<Image>().rectTransform.rect.Contains(localPoint))
                {
                    OptionsMenu.SetActive(value: false);
                    MenuButtons.SetActive(value: true);
                    ((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
                }
            }
        }
    }
}
