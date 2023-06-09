using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class ControlMenu : MonoBehaviour
{
	public Texture2D background;

	public bool display;

	public Font font;

	public ControllerScene[] controllers;

	public Transform[] destroyOnLoad;

	public GameObject launchIntro;

	public GameObject orbEmitter;

	private int selection;

	private bool displayBackground;

	public virtual void Start()
	{
		launchIntro.SetActive(value: false);
		orbEmitter.GetComponent<Renderer>().enabled = false;
	}

	public virtual void Update()
	{
		if (display || selection != -1 || Input.touchCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Input.touchCount; i++)
		{
            Touch touch = Input.GetTouch(i);
            RectTransform rectTransform = GetComponent<RectTransform>();
            Vector2 touchPosition = touch.position;
            bool isTouchInsideImage = RectTransformUtility.RectangleContainsScreenPoint(rectTransform, touchPosition);

            if (touch.phase == TouchPhase.Began && isTouchInsideImage)
            {
                display = true;
                displayBackground = false;
                GetComponent<Image>().enabled = false;
            }
        }
	}

	public virtual void OnGUI()
	{
		GUI.skin.font = font;
		if (displayBackground)
		{
			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), background, ScaleMode.StretchToFill, alphaBlend: false);
		}
		if (!display)
		{
			return;
		}
		int num = -1;
		int num2 = 60;
		int num3 = 400;
		GUILayout.BeginArea(new Rect((Screen.width - num3) / 2, (Screen.height - num2) / 2, num3, num2));
		GUILayout.BeginHorizontal();
		for (int i = 0; i < controllers.Length; i++)
		{
			if (GUILayout.Button(controllers[i].label, GUILayout.MinHeight(num2)))
			{
				num = i;
			}
		}
		if (num >= 0)
		{
			selection = num;
			GetComponent<Image>().enabled = false;
			display = false;
			displayBackground = false;
			StartCoroutine(ChangeControls());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public virtual IEnumerator WaitUntilObjectDestroyed(object o)
	{
		while (o != null)
		{
			yield return new WaitForFixedUpdate();
		}
	}

	public virtual IEnumerator ChangeControls()
	{
		Transform[] array = destroyOnLoad;
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
		launchIntro.SetActive(value: true);
		yield return StartCoroutine(WaitUntilObjectDestroyed(launchIntro));
		displayBackground = true;
		orbEmitter.GetComponent<Renderer>().enabled = true;
		SceneManager.LoadScene(controllers[selection].controlScene);
		UnityEngine.Object.Destroy(base.gameObject, 1f);
	}

	public ControlMenu()
	{
		selection = -1;
	}
}
