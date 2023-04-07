using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class coffinButtonBackyard : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject inCoffin;

	public GameObject underBedCam;

	public GameObject coffinLock;

	public GameObject playerPosition;

	public bool PlayerHiding;

	public GameObject playerCam;

	public GameObject crouchButton;

	public GameObject soundHolder;

	public GameObject dropButtonHolder;

	public GameObject hidingSoundHolder;

	public GameObject shootGunButtonHolder;

	public GameObject pickupButton;

	public GameObject openDoorButton;

	public GameObject mittenRing;

	public Sprite hideTexture;

	public Sprite UnhideTexture;

	public Image button;

	public float lockRotXNer;

	public float lockRotXUpp;

	public virtual void Start()
	{
		PlayerHiding = false;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.R) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			if (!PlayerHiding)
			{
				player.SetActive(value: false);
				PlayerHiding = true;
				inCoffin.SetActive(value: true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				coffinLock.transform.localEulerAngles = new Vector3(lockRotXNer, 0f, 0f);
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffinBackyard = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffinBY = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				crouchButton.SetActive(value: false);
				dropButtonHolder.SetActive(value: false);
				shootGunButtonHolder.SetActive(value: false);
				pickupButton.SetActive(value: false);
				openDoorButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				((hideSound)hidingSoundHolder.GetComponent(typeof(hideSound))).theSound();
			}
			else
			{
				inCoffin.SetActive(value: false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(value: true);
				player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).resetMouse();
				((playerCrawl)crouchButton.GetComponent(typeof(playerCrawl))).standUp();
				coffinLock.transform.localEulerAngles = new Vector3(lockRotXUpp, 0f, 0f);
				PlayerHiding = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffinBackyard = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffinBY = false;
				crouchButton.SetActive(value: true);
				dropButtonHolder.SetActive(value: true);
				shootGunButtonHolder.SetActive(value: true);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CoffinUt();
			}
		}
		if (PlayerHiding)
		{
			button = GetComponent<Image>();
			button.sprite = UnhideTexture;
		}
		else
		{
			button = GetComponent<Image>();
			button.sprite = hideTexture;
		}
	}
}
