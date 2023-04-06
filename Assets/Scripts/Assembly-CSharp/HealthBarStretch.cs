using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class HealthBarStretch : MonoBehaviour
{
	public float scaledWidth;

	public float scaledHeight;

	private Rect defaultRect;

	public Image gui;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}
}
