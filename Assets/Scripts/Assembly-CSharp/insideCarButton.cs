using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class insideCarButton : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject inCoffin;

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

	public float lockRotXNer;

	public float lockRotXUpp;

	public GameObject startButton;

	public GameObject reverseButton;

	public GameObject forwardButton;

	public GameObject gameController;

	public GameObject engineOffSound;

	public GameObject engineOnSound;

	public GameObject engineStartSound;

	public GameObject objectsHolder;

	public bool drivingCar;

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
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCar = true;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				crouchButton.SetActive(value: false);
				dropButtonHolder.SetActive(value: false);
				shootGunButtonHolder.SetActive(value: false);
				pickupButton.SetActive(value: false);
				openDoorButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				startButton.SetActive(value: true);
				engineOffSound.SetActive(value: false);
				objectsHolder.SetActive(value: false);
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
				PlayerHiding = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCar = false;
				((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerStartCar = false;
				crouchButton.SetActive(value: true);
				dropButtonHolder.SetActive(value: true);
				shootGunButtonHolder.SetActive(value: true);
				startButton.SetActive(value: false);
				reverseButton.SetActive(value: false);
				forwardButton.SetActive(value: false);
				objectsHolder.SetActive(value: true);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CarOut();
				if (((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).engineOn)
				{
					engineOffSound.SetActive(value: true);
					engineOnSound.SetActive(value: false);
					engineStartSound.SetActive(value: false);
					((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).engineOn = false;
				}
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
