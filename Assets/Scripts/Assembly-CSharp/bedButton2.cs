using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class bedButton2 : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject underBed;

	public GameObject underBedCam;

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
				underBed.SetActive(value: true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
				PlayerHiding = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed2 = true;
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
				underBed.SetActive(value: false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(value: true);
				player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).resetMouse();
				((playerCrawl)crouchButton.GetComponent(typeof(playerCrawl))).standUp();
				PlayerHiding = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed2 = false;
				crouchButton.SetActive(value: true);
				dropButtonHolder.SetActive(value: true);
				shootGunButtonHolder.SetActive(value: true);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).fromBed();
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
