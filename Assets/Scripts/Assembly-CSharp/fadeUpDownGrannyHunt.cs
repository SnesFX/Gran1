using System;
using UnityEngine;

[Serializable]
public class fadeUpDownGrannyHunt : MonoBehaviour
{
	public bool playerCaught;

	public bool grannySmackPlayer;

	public bool grannyDead;

	public bool startFade;

	public bool musicOn;

	public bool startMusic;

	public bool stopMusic;

	public float volume;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!playerCaught)
		{
			if (grannyDead)
			{
				musicOn = false;
				startMusic = false;
				GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
				if (GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					GetComponent<AudioSource>().volume = 0f;
					GetComponent<AudioSource>().Stop();
					playerCaught = false;
					grannyDead = false;
				}
			}
			else if (startFade)
			{
				if (!musicOn)
				{
					GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
					if (GetComponent<AudioSource>().volume >= 0.7f)
					{
						musicOn = true;
						GetComponent<AudioSource>().volume = 0.7f;
					}
				}
				if (!startMusic)
				{
					startMusic = true;
					GetComponent<AudioSource>().Play();
				}
			}
			else if (!startFade)
			{
				musicOn = false;
				startMusic = false;
				GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
				if (GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					GetComponent<AudioSource>().volume = 0f;
					GetComponent<AudioSource>().Stop();
				}
			}
		}
		else if (!grannySmackPlayer)
		{
			musicOn = false;
			startMusic = false;
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume == 0f)
			{
				startFade = false;
				GetComponent<AudioSource>().volume = 0f;
				GetComponent<AudioSource>().Stop();
				playerCaught = false;
			}
		}
		else
		{
			musicOn = false;
			startMusic = false;
			GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume - 1.05f * Time.deltaTime;
			if (GetComponent<AudioSource>().volume == 0f)
			{
				startFade = false;
				GetComponent<AudioSource>().volume = 0f;
				GetComponent<AudioSource>().Stop();
				playerCaught = false;
				grannySmackPlayer = false;
			}
		}
	}
}
