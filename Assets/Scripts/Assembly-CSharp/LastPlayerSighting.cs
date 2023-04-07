using System;
using UnityEngine;

[Serializable]
public class LastPlayerSighting : MonoBehaviour
{
	public Vector3 position;

	public Vector3 resetPosition;

	public float lightHighIntensity;

	public float lightLowIntensity;

	public float fadeSpeed;

	public float musicFadeSpeed;

	private Light mainLight;

	private AudioSource panicAudio;

	private AudioSource[] sirens;

	public virtual void Awake()
	{
	}

	public virtual void Update()
	{
		SwitchAlarms();
		MusicFading();
	}

	public virtual void SwitchAlarms()
	{
		if (position != resetPosition)
		{
			_ = lightLowIntensity;
		}
		else
		{
			_ = lightHighIntensity;
		}
	}

	public virtual void MusicFading()
	{
		_ = position != resetPosition;
	}

	public LastPlayerSighting()
	{
		position = new Vector3(1000f, 1000f, 1000f);
		resetPosition = new Vector3(1000f, 1000f, 1000f);
		lightHighIntensity = 0.25f;
		fadeSpeed = 7f;
		musicFadeSpeed = 1f;
	}
}
