using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class UseRemote : MonoBehaviour
{
	public GameObject player;

	public GameObject doorLock;

	public Renderer lamp;

	public GameObject doorLockCollider;

	public GameObject lockSound;

	public GameObject door;

	public GameObject doorLockOpen;

	public GameObject doorLockClosed;

	public GameObject soundHolder;

	public GameObject needToGetCloserText;

	public GameObject remoteTextHolder;

	public bool doorUnlocked;

	public bool textTimerOnOff;

	public float textTimer;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!Input.GetMouseButtonDown(0) || ((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			return;
		}
		if (((remoteLocktrigger)doorLock.GetComponent(typeof(remoteLocktrigger))).playerNearDoorLock)
		{
			if (!doorUnlocked)
			{
				doorUnlocked = true;
				door.gameObject.tag = "smalldoorClosed";
				doorLockOpen.SetActive(value: true);
				doorLockClosed.SetActive(value: false);
				doorLockCollider.SetActive(value: false);
				lockSound.SetActive(value: true);
				lamp.material.SetColor("_Color", Color.green);
			}
		}
		else if (!doorUnlocked)
		{
			needToGetCloserText.SetActive(value: true);
			((remoteTextScript)remoteTextHolder.GetComponent(typeof(remoteTextScript))).textTimer = 0f;
			((remoteTextScript)remoteTextHolder.GetComponent(typeof(remoteTextScript))).textTimerOnOff = true;
		}
		((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).clickRemote();
	}
}
