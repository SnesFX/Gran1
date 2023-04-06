using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickMoregamesButton : MonoBehaviour
{
    public GameObject ljudHolder;

    private bool buttonPressed = false;
    private bool buttonsounds = false;

    public void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (GetComponent<Image>().rectTransform.rect.Contains(touch.position))
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