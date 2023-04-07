using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class endDay : MonoBehaviour
{
	public Image blackScreenTexture;

	public float fadeBlackSpeed;

	public float fadeBlackSpeed2;

	public GameObject daysCountHolder;

	public GameObject playerBedAnim;

	public GameObject playerInBedCam;

	public GameObject Granny;

	public GameObject Player;

	public Transform PlayerStartPos;

	public Transform GrannyStartPos;

	public Transform playerCam;

	public Transform playerAnim;

	public Transform playerHead;

	public GameObject crouchButton;

	public GameObject optionButton;

	public GameObject mittPrick;

	public GameObject playerStop;

	public GameObject furnitureHolder;

	public GameObject DoorHolder;

	public GameObject PickUpHolder;

	public GameObject[] beartraps;

	public GameObject bedButton1;

	public GameObject bedButton2;

	public GameObject bedButton3;

	public GameObject dropButtonHolder;

	public GameObject coffinButton1;

	public GameObject coffinButton2;

	public GameObject carButton;

	public Image trapButtonGUI;

	public GameObject trapButton;

	public GameObject trapBar;

	public bool enDayStart;

	public GameObject soundHolder2;

	public GameObject Sound1;

	public GameObject Sound2;

	public GameObject Sound3;

	public GameObject cameraSee;

	public GameObject prisonDoorTrigger;

	public GameObject prisonDoor;

	public GameObject prisonGaller;

	public GameObject prisonGallerColliders;

	public GameObject teddyMusicHolder;

	public GameObject grannyHuntMusicHolder;

	public GameObject brunnsvevButton;

	public GameObject bastuSteamHolder;

	public GameObject Spider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!Player.activeSelf)
		{
			Cursor.visible = false;
			Screen.lockCursor = true;
		}
	}

	public virtual IEnumerator EndDay()
	{
		if (enDayStart)
		{
			yield break;
		}
		((backgroundSound)soundHolder2.GetComponent(typeof(backgroundSound))).fadeDown = true;
		enDayStart = true;
		yield return new WaitForSeconds(2f);
		playerStop = GameObject.Find("Main Camera");
		_ = (CameraFollowExample)playerStop.GetComponent(typeof(CameraFollowExample));
		((fadeUpDownTeddyMusic)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).playerCaught = true;
		((fadeUpDownGrannyHunt)grannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
		blackScreenTexture.CrossFadeAlpha(1f, 0.8f, ignoreTimeScale: false);
		yield return new WaitForSeconds(2f);
		playerAnim.GetComponent<Animation>().Play("PlayerDie");
		playerAnim.GetComponent<Animation>()["PlayerDie"].speed = -50f;
		yield return new WaitForSeconds(3f);
		playerInBedCam.SetActive(value: true);
		playerCam.GetComponent<Camera>().fieldOfView = 60f;
		playerCam.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		Player.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
		((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 6f;
		((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).playerGetCaught = false;
		((FirstPersonController_Egen)Player.GetComponent(typeof(FirstPersonController_Egen))).resetMouse();
		((openDoors)DoorHolder.GetComponent(typeof(openDoors))).playerTaken = false;
		((PickUp)PickUpHolder.GetComponent(typeof(PickUp))).playerTaken = false;
		((PickUp)PickUpHolder.GetComponent(typeof(PickUp))).dropObject = false;
		((playerCaught)Player.GetComponent(typeof(playerCaught))).soundPlaying = false;
		Player.SetActive(value: false);
		Player.transform.position = PlayerStartPos.position;
		Player.transform.rotation = PlayerStartPos.rotation;
		Granny.SetActive(value: false);
		Granny.transform.position = GrannyStartPos.position;
		Granny.SetActive(value: true);
		crouchButton.SetActive(value: false);
		optionButton.SetActive(value: false);
		brunnsvevButton.SetActive(value: false);
		bedButton1.SetActive(value: false);
		bedButton2.SetActive(value: false);
		bedButton3.SetActive(value: false);
		bastuSteamHolder.SetActive(value: false);
		((coffinButton)coffinButton1.GetComponent(typeof(coffinButton))).PlayerHiding = false;
		coffinButton1.SetActive(value: false);
		((coffinButtonBackyard)coffinButton2.GetComponent(typeof(coffinButtonBackyard))).PlayerHiding = false;
		coffinButton2.SetActive(value: false);
		((insideCarButton)carButton.GetComponent(typeof(insideCarButton))).PlayerHiding = false;
		carButton.SetActive(value: false);
		trapButton.SetActive(value: true);
		trapBar.SetActive(value: true);
		trapButtonGUI.CrossFadeAlpha(1f, 0.8f, false);
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).attackingPlayer = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepperStart = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyPepperReact = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannyGonnaSmack = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = false;
		if (Spider.activeSelf)
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).grannyCaughtPlayerReset();
		}
		if (((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison)
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).prisondoorClosed = false;
			cameraSee.SetActive(value: false);
			prisonDoorTrigger.SetActive(value: false);
			prisonGaller.GetComponent<Collider>().enabled = true;
			prisonGallerColliders.SetActive(value: false);
			if (GameObject.Find("prisonDoor") != null)
			{
				prisonDoor.tag = "Untagged";
			}
		}
		mittPrick.SetActive(value: false);
		playerBedAnim.GetComponent<Animation>().Play("PlayerInBed");
		playerBedAnim.GetComponent<Animation>()["PlayerInBed"].speed = -50f;
		StartCoroutine(((furnitureControlls)furnitureHolder.GetComponent(typeof(furnitureControlls))).cleanUp());
		StartCoroutine(((startNewDay)daysCountHolder.GetComponent(typeof(startNewDay))).newDay());
		((resetDay)daysCountHolder.GetComponent(typeof(resetDay))).resetDays();
		((backgroundSound)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)Sound3.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		beartrapDestroy();
		enDayStart = false;
	}

	public virtual void beartrapDestroy()
	{
		beartraps = GameObject.FindGameObjectsWithTag("BearTrapActivated");
		for (int i = 0; i < beartraps.Length; i++)
		{
			UnityEngine.Object.Destroy(beartraps[i]);
		}
	}
}
