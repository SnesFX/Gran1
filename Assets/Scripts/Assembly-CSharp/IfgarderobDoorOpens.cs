using System;
using UnityEngine;

[Serializable]
public class IfgarderobDoorOpens : MonoBehaviour
{
	public GameObject gardeDoorH;

	public GameObject doorButton;

	public GameObject nos;

	public GameObject doorV;

	public GameObject doorH;

	public bool doorsClosed;

	public GameObject player;

	public AudioClip gardeDoorsOpen;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (doorsClosed && GetComponent<Animation>().IsPlaying("VgarderobDoorOpen"))
		{
			doorsClosed = false;
			gardeDoorH.GetComponent<Animation>().Play("HgarderobDoorOpen");
			doorV.gameObject.tag = "Untagged";
			doorH.gameObject.tag = "Untagged";
			((AIfollow)nos.GetComponent(typeof(AIfollow))).playerHiding = false;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 6f;
			((FPSControllerNEW)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 8f;
			doorButton.SetActive(value: false);
			AudioSource.PlayClipAtPoint(gardeDoorsOpen, base.transform.position);
		}
	}

	public IfgarderobDoorOpens()
	{
		doorsClosed = true;
	}
}
