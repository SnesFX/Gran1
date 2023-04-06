using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseSmallDoors : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public bool doorLocked;

	public AudioClip doorLockedLjud;

	public NavMeshObstacle obs;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			obs = GetComponent<NavMeshObstacle>();
			obs.enabled = false;
		}
	}

	public virtual void Update()
	{
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("SmallDoorOpen"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorOpen);
			DoorOpen = true;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			Innerdoor.carving = base.enabled;
			StartCoroutine(timerDooropen());
		}
		if (DoorOpen && GetComponent<Animation>().IsPlaying("SmallDoorClose"))
		{
			GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			base.gameObject.tag = "Untagged";
			StartCoroutine(timerDoorclosed());
		}
		if (!DoorOpen && GetComponent<Animation>().IsPlaying("SmallDoorLocked") && !doorLocked)
		{
			doorLocked = true;
			GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
			StartCoroutine(timerDoorlocked());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "smalldoorOpen";
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return new WaitForSeconds(1f);
		base.gameObject.tag = "smalldoorClosed";
		Innerdoor.carving = !base.enabled;
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorlocked()
	{
		yield return new WaitForSeconds(1f);
		doorLocked = false;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (DoorMoving)
		{
			if (other.gameObject.tag == "Player")
			{
				Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<CharacterController>(), ignore: true);
			}
		}
		else if (!DoorMoving && other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(GetComponent<Collider>(), other.GetComponent<CharacterController>(), ignore: false);
		}
	}
}
