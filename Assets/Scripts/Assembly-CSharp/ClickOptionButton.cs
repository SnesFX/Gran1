using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickOptionButton : MonoBehaviour
{
    public GameObject ljudHolder;

    private bool buttonPressed;

    private bool buttonsounds;

    public GameObject OptionsMenu;

    public GameObject MenuButtons;

    public GameObject noAdsButton;

    public virtual void Start()
    {
    }

    public virtual void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), touch.position, null, out localPoint);
            if (GetComponent<Image>().rectTransform.rect.Contains(localPoint))
            {
                buttonPressed = true;
                base.transform.localPosition = new Vector3(-0.25f, -0.04f, 2f);
                if (!buttonsounds)
                {
                    buttonsounds = true;
                    ((ButtonClicks)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
                }
            }
            else
            {
                base.transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
                buttonPressed = false;
                buttonsounds = false;
            }
        }
        else if (buttonPressed)
        {
            base.transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
            buttonPressed = false;
            OptionsMenu.SetActive(value: true);
            MenuButtons.SetActive(value: false);
            if (PlayerPrefs.GetInt("ADSon") == 0)
            {
                noAdsButton.SetActive(value: true);
            }
        }
    }
}
