using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class openDoors : MonoBehaviour
{
	public int layerMask;

	public GameObject granny;

	public GameObject gameController;

	public GameObject openDoorButton;

	public GameObject removeBTButton;

	public bool resetBTbutton;

	public GameObject doorRay;

	public bool openTheDoor;

	public bool playerTaken;

	public bool removeBeartrap;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject joystick;

	public GameObject microSparks;

	public AudioClip doorLocked;

	public AudioClip microDoor;

	public AudioClip fingerFan;

	public AudioClip giljotinLjud;

	public AudioClip doorLockedLjud;

	public AudioClip secretDoorButton;

	public AudioClip garagePortSound;

	public AudioClip bakluckaLocked;

	public AudioClip brokenCarDoor;

	public AudioClip switchOnOff;

	public AudioClip bastuBomNer;

	public AudioClip bokhyllaLjud;

	public AudioClip crowAttack;

	public AudioClip burDoor;

	public AudioClip moveGaller;

	public bool playSound;

	public GameObject bloodScreenHolder;

	public bool playerFanHurt;

	public bool garageportLock;

	public GameObject garageportAnimHolder;

	public GameObject carSensorFront;

	public GameObject needCarkeyText;

	public GameObject garageportLockedText;

	public bool textTimerOnOff;

	public float textTimer;

	public bool canJumpOut;

	public bool canJumpIn;

	public GameObject camOutToIn;

	public GameObject camInToOut;

	public GameObject winController;

	public GameObject checkPcrouch;

	public GameObject giljotin;

	public GameObject secretDoor;

	public GameObject secretDoorTrigger;

	public GameObject bastuSpak;

	public GameObject bastuSteam;

	public GameObject bastuBom;

	public GameObject bastuDoor;

	public NavMeshObstacle bastuDoorCarv;

	public GameObject noiceObjectBastu;

	public bool droppedNoiceObj;

	public GameObject tavelspak;

	public GameObject bokhylla;

	public bool playerTrySteal;

	public GameObject Crow;

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && (bool)openDoorButton)
		{
			openTheDoor = true;
			playSound = false;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 4f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "innerdoorClosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "innerdoorOpen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "innerdoorLocked" || hitInfo.collider.gameObject.tag == "steeldoorLocked")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "smalldoorClosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("SmallDoorOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "smalldoorOpen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("SmallDoorClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "smalldoorLocked")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("SmallDoorLocked");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorRclosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorHallOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorRopen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorHallClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorLclosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorHallLOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorLopen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorHallLClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorVRLclosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorVRLOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorVRLopen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorVRLClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorVRRclosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorVRROpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vitrindoorVRRopen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("VitrindoorVRRClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kylClosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KylOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kylOpen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KylClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kitchenDoor1Closed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KitchenDoor1Open");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kitchenDoor1Open")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KitchenDoor1Close");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kitchenDoor2Closed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KitchenDoor2Open");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kitchenDoor2Open")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("KitchenDoor2Close");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "loda1Closed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Loda1Open");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "loda1Open")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Loda1Close");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "loda2Closed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Loda2Open");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "loda2Open")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						openTheDoor = false;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Loda2Close");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "garde1Closed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Garde1Open");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "garde1Open")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("Garde1Close");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bakluckaLocked")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havecarKey)
						{
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("bakluckaOpen");
						}
						else
						{
							textTimer = 0f;
							needCarkeyText.SetActive(value: true);
							textTimerOnOff = true;
							GetComponent<AudioSource>().PlayOneShot(bakluckaLocked);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bakluckaClosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("bakluckaOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bakluckaOpen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("bakluckaClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "motorhuvClosed")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("motorhuvOpen");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "motorhuvOpen")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("motorhuvClose");
					}
				}
				else if (hitInfo.collider.gameObject.tag == "garageport")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						if (garageportLock)
						{
							garageportAnimHolder.GetComponent<Animation>().Play("garageportOpen");
							GetComponent<AudioSource>().PlayOneShot(garagePortSound);
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							((carFrontSensor)carSensorFront.GetComponent(typeof(carFrontSensor))).garagedoorOpen = true;
						}
						else if (!playSound)
						{
							playSound = true;
							textTimer = 0f;
							garageportLockedText.SetActive(value: true);
							textTimerOnOff = true;
							GetComponent<AudioSource>().PlayOneShot(brokenCarDoor);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "microdoor")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor)
					{
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("MicroDoorOpen");
						hitInfo.collider.gameObject.tag = "Untagged";
						GetComponent<AudioSource>().PlayOneShot(microDoor);
						microSparks.SetActive(value: true);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "prisondoorlocked")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("prisondoorLocked");
						GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "fanhurt")
				{
					if (!playerFanHurt)
					{
						openDoorButton.SetActive(value: true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
							((playerInBeartrap)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
							playerFanHurt = true;
							openDoorButton.SetActive(value: false);
							GetComponent<AudioSource>().PlayOneShot(fingerFan);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "window")
				{
					if (!((playerCrawl)checkPcrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig)
					{
						if (canJumpOut)
						{
							openDoorButton.SetActive(value: true);
							if (openTheDoor && !playSound)
							{
								playSound = true;
								((PlayerWindowController)winController.GetComponent(typeof(PlayerWindowController))).jumpOut();
								openDoorButton.SetActive(value: false);
								canJumpOut = false;
								checkPcrouch.SetActive(value: false);
							}
						}
						else if (canJumpIn)
						{
							openDoorButton.SetActive(value: true);
							if (openTheDoor && !playSound)
							{
								playSound = true;
								((PlayerWindowController)winController.GetComponent(typeof(PlayerWindowController))).jumpIn();
								openDoorButton.SetActive(value: false);
								canJumpIn = false;
								checkPcrouch.SetActive(value: false);
							}
						}
						else
						{
							openDoorButton.SetActive(value: false);
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "giljotinspak")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						giljotin.gameObject.GetComponent<Animation>().Play("giljotinOn");
						GetComponent<AudioSource>().PlayOneShot(giljotinLjud);
						openDoorButton.SetActive(value: false);
						hitInfo.collider.gameObject.tag = "Untagged";
					}
				}
				else if (hitInfo.collider.gameObject.tag == "secretdoorbutton")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						secretDoor.gameObject.GetComponent<Animation>().Play("SecretDoorOpenLittle");
						GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						secretDoorTrigger.SetActive(value: true);
						openDoorButton.SetActive(value: false);
						hitInfo.collider.gameObject.tag = "Untagged";
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bastuspakOff")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuSpak.GetComponent<Animation>().Play("BastuSpakOn");
						GetComponent<AudioSource>().PlayOneShot(switchOnOff);
						hitInfo.collider.gameObject.tag = "bastuspakOn";
						bastuSteam.GetComponent<ParticleSystem>().enableEmission = true;
						((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuswitchOn = true;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bastuspakOn")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuSpak.GetComponent<Animation>().Play("BastuSpakOff");
						GetComponent<AudioSource>().PlayOneShot(switchOnOff);
						hitInfo.collider.gameObject.tag = "bastuspakOff";
						bastuSteam.GetComponent<ParticleSystem>().enableEmission = false;
						((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuswitchOn = false;
						((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 20f;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bastubomUppe")
				{
					if (bastuDoor.gameObject.tag == "innerdoorClosed")
					{
						openDoorButton.SetActive(value: true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							bastuBom.GetComponent<Animation>().Play("BastuBomNer");
							GetComponent<AudioSource>().PlayOneShot(bastuBomNer);
							hitInfo.collider.gameObject.tag = "Untagged";
							bastuDoor.gameObject.tag = "bastudoorLocked";
							if (((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu)
							{
								bastuDoorCarv.carving = base.enabled;
								noiceObjectBastu.SetActive(value: true);
							}
							StartCoroutine(bastuBommenNere());
							((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = true;
							openDoorButton.SetActive(value: false);
							openTheDoor = false;
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bastubomNere")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuBom.GetComponent<Animation>().Play("BastuBomUpp");
						hitInfo.collider.gameObject.tag = "Untagged";
						bastuDoorCarv.carving = !base.enabled;
						StartCoroutine(bastuBommenUppe());
						((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = false;
						((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).bastuSafeTimer = 0f;
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "brokencardoor")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						GetComponent<AudioSource>().PlayOneShot(brokenCarDoor);
						((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
						hitInfo.collider.gameObject.tag = "Untagged";
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
						((destroyCarDoor)hitInfo.collider.gameObject.GetComponent(typeof(destroyCarDoor))).destroyBrokenCardorr = true;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "handskfack")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("handskfackOpen");
						GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						hitInfo.collider.gameObject.tag = "Untagged";
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "playersteal")
				{
					if (!playerTrySteal)
					{
						openDoorButton.SetActive(value: true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							((CrowControl)Crow.GetComponent(typeof(CrowControl))).playerSteal = true;
							footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
							((playerInBeartrap)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
							playerTrySteal = true;
							openDoorButton.SetActive(value: false);
							GetComponent<AudioSource>().PlayOneShot(crowAttack);
							StartCoroutine(crowAttackPlayer());
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tavelspak")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						tavelspak.gameObject.GetComponent<Animation>().Play("Tavelspak");
						bokhylla.gameObject.GetComponent<Animation>().Play("BookShelfMove");
						bokhylla.GetComponent<AudioSource>().PlayOneShot(bokhyllaLjud);
						hitInfo.collider.gameObject.tag = "Untagged";
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "burdoor")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("BurDoorOpen");
						((CrowControl)Crow.GetComponent(typeof(CrowControl))).burdoorIsOpen = true;
						GetComponent<AudioSource>().PlayOneShot(burDoor);
						hitInfo.collider.gameObject.tag = "Untagged";
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "gallerhole")
				{
					openDoorButton.SetActive(value: true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("GallerHole");
						GetComponent<AudioSource>().PlayOneShot(moveGaller);
						hitInfo.collider.gameObject.tag = "Untagged";
						openDoorButton.SetActive(value: false);
						openTheDoor = false;
					}
				}
				else if (hitInfo.collider.gameObject.tag == "golv")
				{
					openDoorButton.SetActive(value: false);
					openTheDoor = false;
				}
				else if (hitInfo.collider.gameObject.tag == "car")
				{
					openDoorButton.SetActive(value: false);
					openTheDoor = false;
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					openDoorButton.SetActive(value: false);
					openTheDoor = false;
				}
				else if (hitInfo.collider.gameObject.tag == "remoteLock")
				{
					openDoorButton.SetActive(value: false);
					openTheDoor = false;
				}
			}
			else
			{
				openDoorButton.SetActive(value: false);
				openTheDoor = false;
			}
		}
		else
		{
			openDoorButton.SetActive(value: false);
		}
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				needCarkeyText.SetActive(value: false);
				garageportLockedText.SetActive(value: false);
			}
		}
	}

	public virtual IEnumerator bastuBommenNere()
	{
		yield return new WaitForSeconds(1f);
		bastuBom.gameObject.tag = "bastubomNere";
		noiceObjectBastu.SetActive(value: false);
	}

	public virtual IEnumerator bastuBommenUppe()
	{
		yield return new WaitForSeconds(1f);
		bastuBom.gameObject.tag = "bastubomUppe";
		bastuDoor.gameObject.tag = "innerdoorClosed";
	}

	public virtual IEnumerator crowAttackPlayer()
	{
		yield return new WaitForSeconds(2f);
		playerTrySteal = false;
	}

	public openDoors()
	{
		layerMask = 256;
	}
}
