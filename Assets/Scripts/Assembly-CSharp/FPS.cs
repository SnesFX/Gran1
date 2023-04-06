using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class FPS : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	public virtual void Start()
	{
		if (!GetComponent<Text>())
		{
			MonoBehaviour.print("FramesPerSecond needs a UI.Text component!");
			base.enabled = false;
		}
		else
		{
			timeleft = updateInterval;
		}
	}

	public virtual void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale / Time.deltaTime;
		frames++;
		if (timeleft <= 0f)
		{
			GetComponent<Text>().text = (accum / (float)frames).ToString("f2") ?? "";
			timeleft = updateInterval;
			accum = 0f;
			frames = 0;
		}
	}

	public FPS()
	{
		updateInterval = 0.5f;
	}
}
