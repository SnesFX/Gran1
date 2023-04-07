using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickMoregamesButton : MonoBehaviour
{
    public GameObject ljudHolder;
    public bool buttonPressed;
    public bool buttonsounds;

    public virtual void Start()
    {
    }

    public virtual void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 position = touch.position;
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), position, Camera.main, out localPoint);
            if (RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), touch.position))
            {
                buttonPressed = true;
                transform.localPosition = new Vector3(-0.25f, -0.17f, 2f);
                if (!buttonsounds)
                {
                    buttonsounds = true;
                    ((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
                }
            }
            else
            {
                transform.localPosition = new Vector3(-0.28f, -0.17f, 2f);
                buttonsounds = false;
                buttonPressed = false;
            }
        }
        else if (buttonPressed)
        {
            transform.localPosition = new Vector3(-0.28f, -0.17f, 2f);
            buttonPressed = false;
            buttonsounds = false;
            Application.OpenURL("http://play.google.com/store/apps/developer?id=DVloper");
        }
    }
}
