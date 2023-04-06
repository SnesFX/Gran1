using System;
using UnityEngine;

[Serializable]
public class Footsteps : MonoBehaviour
{
	public AudioClip[] footstepConcrete;

	public AudioClip[] footstepConcreteSticky;

	public AudioClip[] footstepGrus;

	public AudioClip[] footstepWater;

	public bool isWalking;

	public bool walkGrus;

	public bool walkWater;

	public GameObject headBob;

	public bool day2;

	public bool day3;

	public bool playerDie;

	public bool playerCrouching;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void step()
	{
		if (!isWalking)
		{
			return;
		}
		if (!walkGrus && !walkWater)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				int num = UnityEngine.Random.Range(0, footstepConcreteSticky.Length);
				GetComponent<AudioSource>().PlayOneShot(footstepConcreteSticky[num]);
			}
			else
			{
				int num2 = UnityEngine.Random.Range(0, footstepConcrete.Length);
				GetComponent<AudioSource>().PlayOneShot(footstepConcrete[num2]);
			}
		}
		else if (walkGrus)
		{
			int num3 = UnityEngine.Random.Range(0, footstepGrus.Length);
			GetComponent<AudioSource>().PlayOneShot(footstepGrus[num3]);
		}
		else if (walkWater)
		{
			int num4 = UnityEngine.Random.Range(0, footstepWater.Length);
			GetComponent<AudioSource>().PlayOneShot(footstepWater[num4]);
		}
	}

	public virtual void walk()
	{
		if (playerDie || headBob.GetComponent<Animation>().IsPlaying("playerHurt"))
		{
			return;
		}
		if (isWalking)
		{
			if (day2)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation2");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 1f;
				}
			}
			else if (day3)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation3");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 1f;
				}
			}
			else
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation");
				if (playerCrouching)
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
				}
				else
				{
					headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
				}
			}
		}
		else if (day2)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation2"].speed = 1f;
			}
		}
		else if (day3)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation3"].speed = 1f;
			}
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
			if (playerCrouching)
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
			}
			else
			{
				headBob.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
			}
		}
	}

	public virtual void stopwalk()
	{
		GetComponent<AudioSource>().Stop();
		if (day2)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
		}
		else if (day3)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
		}
	}

	public Footsteps()
	{
		isWalking = true;
	}
}
