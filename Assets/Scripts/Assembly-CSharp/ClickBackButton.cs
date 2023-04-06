using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ClickBackButton : MonoBehaviour
{
    public GameObject Menu;

    public GameObject difficultyMenu;

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
                Vector2 localPoint;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(), touch.position, null, out localPoint);
                if (GetComponent<Image>().rectTransform.rect.Contains(localPoint))
                {
                    ((soundEffectsMenu)ljudHolder.GetComponent(typeof(soundEffectsMenu))).buttonClick();
                    difficultyMenu.SetActive(value: false);
                    Menu.SetActive(value: true);
                }
            }
        }
    }
}
