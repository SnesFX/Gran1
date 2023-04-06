using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class EnemyAIGranny : MonoBehaviour
{
	public Transform myTransform;

	public Transform grannyEye;

	public GameObject grannyLock;

	public Transform target;

	public Transform bedtargetTemp1;

	public Transform bedtargetTemp2;

	public Transform bedtargetTemp3;

	public Transform coffintargetTemp4;

	public Transform coffintargetTempBY;

	public Transform cartargetTemp;

	public GameObject bedCam1;

	public GameObject bedCam2;

	public GameObject bedCam3;

	public GameObject coffinHead1;

	public GameObject coffinHead2;

	public GameObject carHead;

	public bool hidingUnderBed1;

	public bool hidingUnderBed2;

	public bool hidingUnderBed3;

	public bool hidingInCoffin4;

	public bool hidingInCoffinBY;

	public bool hidingInCar;

	public bool playerHiding;

	public bool playerInHole;

	public bool grannyInBastu;

	public bool bastuswitchOn;

	public bool bastuBomNere;

	public bool bastuTimeOff;

	public float bastuTimer;

	public float bastuDoorTimer;

	public GameObject bastuDoor;

	public NavMeshObstacle bastuDoorCarv;

	public GameObject bastuBom;

	public bool StartbastuSafeTimer;

	public float bastuSafeTimer;

	public Transform player;

	public GameObject Player;

	public Transform playerPos;

	public NavMeshAgent navComponent;

	public float number;

	public float speed;

	public Transform nav1;

	public Transform nav2;

	public Transform nav3;

	public Transform nav4;

	public Transform nav5;

	public Transform nav6;

	public Transform nav7;

	public Transform nav8;

	public Transform nav9;

	public Transform nav10;

	public Transform nav11;

	public Transform nav12;

	public Transform nav13;

	public Transform nav14;

	public Transform nav15;

	public Transform nav16;

	public bool seePlayer;

	public bool seePlayerTimer;

	public float offScreenDot;

	public bool waypointStop;

	public bool waypointStart;

	public float distanceWaypoint;

	public float distance;

	public float attackDistance;

	public bool waypointWaitTime;

	public bool timerOnOff;

	public float timer;

	public float timerSee;

	public float timerSearch;

	public float timerBed;

	public float safeTimer;

	public bool resetSafeTimer;

	public bool startTimerSearch;

	public bool GrannySearching;

	public bool GrannySearch;

	public bool GrannyMoving;

	public bool attackingPlayer;

	public bool huntPlayer;

	public bool grannyIsFollow;

	public GameObject animationHolder;

	public bool startWalk;

	public bool stopWalk;

	public bool startAttack;

	public bool grannyHearPlayer;

	public bool grannyHearObject;

	public bool playerHidingUnderBed;

	public bool playerHidingInCoffin;

	public bool playerHidingInCoffinBackyard;

	public bool playerHidingInCar;

	public bool grannyStandBesideCar;

	public bool grannyLookUnderBed;

	public GameObject allBedButtons;

	public bool playerGetCaught;

	public bool checkInstansName;

	public bool playerFallDeath;

	public bool dontHitPlayer;

	public GameObject doorRay;

	public GameObject checkGround;

	public float seeClosedDoorTimer;

	public bool grannySeeDoor;

	public bool grannySeeLockedDoor;

	public bool stopSeeLockedDoor;

	public GameObject gameController;

	public bool playerCaughtLastTime;

	public GameObject playerHukaKnapp;

	public GameObject playerHukaKnappParent;

	public GameObject optionButton;

	public Transform PlayerCoffinPos;

	public Transform PlayerCoffinBYPos;

	public Transform PlayerCarPos;

	public GameObject coffinLock;

	public GameObject coffinLockBY;

	public GameObject Spider;

	public GameObject bearTrap;

	public GameObject bearTrapOrganic;

	public Transform bearTrapSP;

	public bool droppingBeartrap;

	public bool soundPlaying;

	public GameObject soundHolder1;

	public GameObject soundHolder2;

	public GameObject soundHolder3;

	public GameObject playerSounds;

	public GameObject grannySounds;

	public GameObject[] NPoints;

	public bool seeStairs;

	public bool hitByArrow;

	public bool hitByGun;

	public bool hitByCar;

	public bool hitByPepper;

	public bool hitByPepperStart;

	public bool freeze;

	public bool bastuKilled;

	public bool ragdollSpawn;

	public Transform grannyRagdoll;

	public Transform grannyForceRagdoll;

	public Transform grannyFreezedoll;

	public GameObject grannyDisaper;

	public GameObject grannyGoneNormalText1;

	public GameObject grannyGoneEasyText1;

	public GameObject grannyGoneHardText1;

	public GameObject grannyGoneExtremeText1;

	public GameObject grannyGoneEasyShotText;

	public GameObject grannyGoneNormalShotText;

	public GameObject grannyGoneHardShotText;

	public GameObject grannyGoneExtremeShotText;

	public float grannysVarSpeed;

	public float grannysAnimSpeed;

	public bool turnFacePlayer;

	public bool playerInPrison;

	public bool prisondoorClosed;

	public bool playerNearGranny;

	public bool GrannyGonnaSmack;

	public bool playerHaveTeddy;

	public bool spiderIsDead;

	public bool playerStartCar;

	public bool grannyEyeColorTimerOn;

	public float grannyEyeColorTimer;

	public float blindTimer = 30f;

	public bool grannyPepperReact;

	public GameObject grannyEyeColor;

	public GameObject teddyMusicHolder;

	public GameObject GrannyHuntMusicHolder;

	public GameObject startCarButton;

	public GameObject forwardButton;

	public GameObject reverseButton;

	public GameObject engineOnSound;

	public GameObject engineOffSound;

	public GameObject engineStartSound;

	public GameObject ObjectHolder;

	public GameObject grannyCloseTrigger;

	public virtual void Start()
	{
		hitByArrow = false;
		hitByGun = false;
		hitByCar = false;
		hitByPepper = false;
		hitByPepperStart = false;
		freeze = false;
		grannyLock.SetActive(value: false);
		grannyPepperReact = false;
		GrannyGonnaSmack = false;
		bastuKilled = false;
		grannyStandBesideCar = false;
		playerInPrison = false;
		target = nav1;
		number = UnityEngine.Random.Range(1, 33);
		if (number == 1f || number == 2f)
		{
			target = GameObject.Find("Nav1").transform;
		}
		if (number == 3f || number == 4f)
		{
			target = GameObject.Find("Nav2").transform;
		}
		if (number == 5f || number == 6f)
		{
			target = GameObject.Find("Nav3").transform;
		}
		if (number == 7f || number == 8f)
		{
			target = GameObject.Find("Nav4").transform;
		}
		if (number == 9f || number == 10f)
		{
			target = GameObject.Find("Nav5").transform;
		}
		if (number == 11f || number == 12f)
		{
			target = GameObject.Find("Nav6").transform;
		}
		if (number == 13f || number == 14f)
		{
			target = GameObject.Find("Nav7").transform;
		}
		if (number == 15f || number == 16f)
		{
			target = GameObject.Find("Nav8").transform;
		}
		if (number == 17f || number == 18f)
		{
			target = GameObject.Find("Nav9").transform;
		}
		if (number == 19f || number == 20f)
		{
			target = GameObject.Find("Nav10").transform;
		}
		if (number == 21f || number == 22f)
		{
			target = GameObject.Find("Nav11").transform;
		}
		if (number == 23f || number == 24f)
		{
			target = GameObject.Find("Nav12").transform;
		}
		if (number == 25f || number == 26f)
		{
			target = GameObject.Find("Nav13").transform;
		}
		if (number == 27f || number == 28f)
		{
			target = GameObject.Find("Nav14").transform;
		}
		if (number == 29f || number == 30f)
		{
			target = GameObject.Find("Nav15").transform;
		}
		if (number == 31f || number == 32f)
		{
			target = GameObject.Find("Nav16").transform;
		}
		navComponent = (NavMeshAgent)base.transform.GetComponent(typeof(NavMeshAgent));
		player = GameObject.Find("Player").transform;
		playerPos = GameObject.Find("Main Camera").transform;
		nav1 = GameObject.Find("Nav1").transform;
		nav2 = GameObject.Find("Nav2").transform;
		nav3 = GameObject.Find("Nav3").transform;
		nav4 = GameObject.Find("Nav4").transform;
		nav5 = GameObject.Find("Nav5").transform;
		nav6 = GameObject.Find("Nav6").transform;
		nav7 = GameObject.Find("Nav7").transform;
		nav8 = GameObject.Find("Nav8").transform;
		nav9 = GameObject.Find("Nav9").transform;
		nav10 = GameObject.Find("Nav10").transform;
		nav11 = GameObject.Find("Nav11").transform;
		nav12 = GameObject.Find("Nav12").transform;
		nav13 = GameObject.Find("Nav13").transform;
		nav14 = GameObject.Find("Nav14").transform;
		nav15 = GameObject.Find("Nav15").transform;
		nav16 = GameObject.Find("Nav16").transform;
		navComponent.speed = 1.2f;
		if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
		{
			grannysVarSpeed = 4.3f;
			grannysAnimSpeed = 2f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			grannysVarSpeed = 3f;
			grannysAnimSpeed = 1.5f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			grannysVarSpeed = 5f;
			grannysAnimSpeed = 2.7f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5)
		{
			grannysVarSpeed = 7f;
			grannysAnimSpeed = 3.3f;
		}
	}

	public virtual void FixedUpdate()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			if (playerHaveTeddy && !freeze)
			{
				grannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.2264151f, 0f, 0f);
				grannyEyeColorTimerOn = true;
				grannyEyeColorTimer = 0f;
				((fadeUpDownTeddyMusic)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).startFade = true;
			}
			else if (grannyEyeColorTimerOn)
			{
				grannyEyeColorTimer += Time.deltaTime;
				if (grannyEyeColorTimer > 7f)
				{
					grannyEyeColorTimerOn = false;
					grannyEyeColorTimer = 0f;
					grannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.5882353f, 0.5882353f, 0.5882353f);
					((fadeUpDownTeddyMusic)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).startFade = false;
				}
			}
		}
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			int num = 0;
			Quaternion rotation = base.transform.rotation;
			rotation.x = num;
			base.transform.rotation = rotation;
			if ((bool)target)
			{
				distanceWaypoint = Vector3.Distance(target.position, base.transform.position);
			}
			distance = Vector3.Distance(playerPos.position, grannyEye.transform.position);
		}
		if (playerGetCaught && playerFallDeath)
		{
			navComponent.speed = 0f;
			animationHolder.GetComponent<Animation>().CrossFade("idle");
		}
		if (!playerGetCaught)
		{
			if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && target == null)
			{
				target = nav1;
			}
			if (!grannyIsFollow && !grannyLookUnderBed && !playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				safeTimer += Time.deltaTime;
				if (safeTimer >= 80f)
				{
					safeTimer = 0f;
					if (target.name != "Player")
					{
						grannyHearObject = false;
						grannyHearPlayer = false;
						number = UnityEngine.Random.Range(1, 33);
						newNav();
					}
				}
			}
			if (!playerGetCaught)
			{
				if (hitByArrow)
				{
					((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						base.gameObject.tag = "Untagged";
						animationHolder.GetComponent<Animation>().CrossFade("arrowHit");
						animationHolder.GetComponent<Animation>()["arrowHit"].speed = 0.8f;
						StartCoroutine(grannyHitByArrow());
						huntPlayer = false;
					}
				}
				else if (hitByGun)
				{
					((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						grannyHitByGun();
						huntPlayer = false;
					}
				}
				else if (hitByCar)
				{
					((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						base.gameObject.tag = "Untagged";
						grannyHitByCar();
						huntPlayer = false;
					}
				}
				else if (freeze)
				{
					((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						base.gameObject.tag = "Untagged";
						animationHolder.GetComponent<Animation>().CrossFade("freezeTrap");
						animationHolder.GetComponent<Animation>()["freezeTrap"].speed = 1f;
						StartCoroutine(grannyFreeze());
						huntPlayer = false;
					}
				}
			}
			if (navComponent.velocity != Vector3.zero)
			{
				if (!grannyLookUnderBed && !playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					stopWalk = false;
					GrannyMoving = true;
					if (!startWalk)
					{
						if (!grannyIsFollow)
						{
							if (!grannySeeDoor && !grannySeeLockedDoor && !droppingBeartrap)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Walk");
								animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
								navComponent.speed = 1.2f;
							}
						}
						else if (seePlayer)
						{
							animationHolder.GetComponent<Animation>().CrossFade("Walk");
							animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
							navComponent.stoppingDistance = 2f;
						}
					}
				}
			}
			else if (navComponent.velocity == Vector3.zero && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !grannyLookUnderBed)
			{
				startWalk = false;
				GrannyMoving = false;
				if (!stopWalk)
				{
					stopWalk = true;
					if (!attackingPlayer && !GrannySearch && !huntPlayer)
					{
						if (grannyHearPlayer)
						{
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Look");
							}
						}
						else if (grannyHearObject)
						{
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Look");
							}
						}
						else if (navComponent.velocity == Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
						}
					}
				}
			}
			if ((bool)target && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				navComponent.destination = target.position;
				if (!seePlayer && !grannyIsFollow && !GrannySearching)
				{
					if (prisondoorClosed)
					{
						if (waypointStart && !waypointStop)
						{
							waypointStart = false;
							waypointStop = true;
							timer = 0f;
							if (target.name == "TempNavObjects(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								StartCoroutine(cleaning());
							}
							if (target.name == "TempNav(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
							}
						}
					}
					else if (distanceWaypoint < 5f)
					{
						if (waypointStart && !waypointStop)
						{
							waypointStart = false;
							waypointStop = true;
							timer = 0f;
							if (target.name == "TempNavObjects(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								StartCoroutine(cleaning());
							}
							if (target.name == "TempNav(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
							}
						}
					}
					else if (distanceWaypoint > 3f && !waypointStop)
					{
						waypointStart = true;
						waypointStop = false;
					}
				}
			}
			if (waypointStop && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !startTimerSearch && (!grannyHearObject || !grannyHearPlayer))
			{
				timer += Time.deltaTime;
			}
			if (timer >= 10f && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				waypointStop = false;
				waypointStart = true;
				timer = 0f;
				if (!grannyIsFollow)
				{
					number = UnityEngine.Random.Range(1, 33);
					if (!grannyHearPlayer || !grannyHearObject)
					{
						newNav();
					}
				}
			}
			if (seePlayer)
			{
				if (!grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					grannyHearPlayer = false;
					grannyHearObject = false;
					timerSee = 0f;
					safeTimer = 0f;
					if (!huntPlayer)
					{
						huntPlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
						}
						if (!grannyIsFollow)
						{
							grannyIsFollow = true;
							followPlayer();
						}
					}
				}
			}
			else if (playerHaveTeddy)
			{
				if (PlayerPrefs.GetInt("DiffData") != 4 && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					grannyHearPlayer = false;
					grannyHearObject = false;
					timerSee = 0f;
					safeTimer = 0f;
					if (!huntPlayer)
					{
						huntPlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
						}
						if (!grannyIsFollow)
						{
							grannyIsFollow = true;
							followPlayer();
						}
					}
				}
			}
			else if (playerStartCar && PlayerPrefs.GetInt("DiffData") != 4 && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				grannyHearPlayer = false;
				grannyHearObject = false;
				timerSee = 0f;
				safeTimer = 0f;
				seePlayer = true;
				if (!huntPlayer)
				{
					huntPlayer = true;
					if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
					{
						((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
					}
					if (!grannyIsFollow)
					{
						grannyIsFollow = true;
						followPlayer();
					}
				}
			}
			if (grannyIsFollow && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				if (!seePlayer)
				{
					seePlayerTimer = true;
				}
				else
				{
					seePlayerTimer = false;
					timerSee = 0f;
					safeTimer = 0f;
				}
			}
			if (seePlayerTimer && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				timerSee += Time.deltaTime;
				if (timerSee >= 6f)
				{
					seePlayerTimer = false;
					grannyIsFollow = false;
					huntPlayer = false;
					if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
					{
						((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = false;
					}
					timerSee = 0f;
					safeTimer = 0f;
					startTimerSearch = true;
					GrannySearching = true;
				}
			}
			if (startTimerSearch && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				if (GrannySearching)
				{
					navComponent.speed = 0f;
					if (!GrannySearch && navComponent.velocity == Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("Look");
					}
				}
				timerSearch += Time.deltaTime;
				if (timerSearch >= 8f)
				{
					if (navComponent.velocity != Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("Walk");
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
					animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
					grannyHearPlayer = false;
					grannyHearObject = false;
					if (!grannyIsFollow)
					{
						startTimerSearch = false;
						GrannySearching = false;
						GrannySearch = false;
						timerSearch = 0f;
						if (!grannySeeDoor && !grannySeeLockedDoor)
						{
							navComponent.speed = 1.2f;
						}
						number = UnityEngine.Random.Range(1, 33);
						if (!grannyHearPlayer || !grannyHearObject)
						{
							newNav();
							if (PlayerPrefs.GetInt("DiffData") != 4)
							{
								StartCoroutine(dropBearTrap());
							}
							if (playerInPrison && prisondoorClosed)
							{
								((GrannySounds)grannySounds.GetComponent(typeof(GrannySounds))).grannySkrattar();
							}
							else
							{
								((GrannySounds)grannySounds.GetComponent(typeof(GrannySounds))).startGrannySound();
							}
						}
					}
				}
			}
			if (PlayerPrefs.GetInt("DiffData") != 4)
			{
				Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
				doorRay.transform.TransformDirection(Vector3.down);
				if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 3f))
				{
					if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
					{
						Debug.DrawRay(doorRay.transform.position, base.transform.forward, Color.green);
						if (hitInfo.collider.gameObject.tag == "innerdoorClosed")
						{
							grannySeeDoor = true;
							if (!seePlayer)
							{
								if (playerHaveTeddy)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else if (playerStartCar)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else
								{
									navComponent.speed = 0f;
								}
							}
							seeClosedDoorTimer += Time.deltaTime;
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
							}
							if (seeClosedDoorTimer >= 2f)
							{
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
								if (!grannyIsFollow)
								{
									navComponent.speed = 1.2f;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
								}
								else
								{
									navComponent.speed = grannysVarSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
								}
								seeClosedDoorTimer = 0f;
							}
						}
						else if (hitInfo.collider.gameObject.tag == "innerdoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									if (playerHaveTeddy)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else if (playerStartCar)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else
									{
										navComponent.speed = 0f;
									}
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (seeClosedDoorTimer <= 2f)
								{
									hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
								}
								if (seeClosedDoorTimer >= 4f)
								{
									hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
									if (!grannyIsFollow)
									{
										navComponent.speed = 1.2f;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									if (grannySeeLockedDoor && seeClosedDoorTimer >= 10f)
									{
										grannySeeLockedDoor = false;
										stopSeeLockedDoor = true;
										seeClosedDoorTimer = 0f;
										grannyHearPlayer = false;
										grannyHearObject = false;
										number = UnityEngine.Random.Range(1, 33);
										newNav();
									}
								}
							}
						}
						else if (hitInfo.collider.gameObject.tag == "steeldoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									if (playerHaveTeddy)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else if (playerStartCar)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else
									{
										navComponent.speed = 0f;
									}
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (seeClosedDoorTimer <= 2f)
								{
									hitInfo.collider.gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
								}
								if (seeClosedDoorTimer >= 4f)
								{
									if (!grannyIsFollow)
									{
										navComponent.speed = 1.2f;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									if (grannySeeLockedDoor && seeClosedDoorTimer >= 10f)
									{
										grannySeeLockedDoor = false;
										stopSeeLockedDoor = true;
										seeClosedDoorTimer = 0f;
										grannyHearPlayer = false;
										grannyHearObject = false;
										number = UnityEngine.Random.Range(1, 33);
										newNav();
									}
								}
							}
						}
						else if (hitInfo.collider.gameObject.tag == "bastudoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								if (seeClosedDoorTimer >= 4f)
								{
									if (!grannyIsFollow)
									{
										navComponent.speed = 1.2f;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									if (grannySeeLockedDoor && seeClosedDoorTimer >= 10f)
									{
										grannySeeLockedDoor = false;
										stopSeeLockedDoor = false;
										seeClosedDoorTimer = 0f;
										grannyHearPlayer = false;
										grannyHearObject = false;
										number = UnityEngine.Random.Range(1, 33);
										newNav();
									}
								}
							}
						}
						else if (hitInfo.collider.gameObject.tag == "smalldoorClosed")
						{
							grannySeeDoor = true;
							if (!seePlayer)
							{
								if (playerHaveTeddy)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else if (playerStartCar)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else
								{
									navComponent.speed = 0f;
								}
							}
							seeClosedDoorTimer += Time.deltaTime;
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
							}
							if (seeClosedDoorTimer >= 2f)
							{
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("SmallDoorOpen");
								if (navComponent.velocity != Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("Walk");
								}
								else
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								if (!grannyIsFollow)
								{
									navComponent.speed = 1.2f;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
										animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
								}
								else
								{
									navComponent.speed = grannysVarSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
								}
								seeClosedDoorTimer = 0f;
							}
						}
						else if (hitInfo.collider.gameObject.tag == "garde1Closed")
						{
							grannySeeDoor = true;
							if (grannyIsFollow)
							{
								if (!seePlayer)
								{
									if (playerHiding)
									{
										navComponent.speed = 0f;
										seeClosedDoorTimer += Time.deltaTime;
										if (navComponent.velocity == Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										if (seeClosedDoorTimer >= 2f)
										{
											hitInfo.collider.gameObject.GetComponent<Animation>().Play("Garde1Open");
											if (navComponent.velocity != Vector3.zero)
											{
												animationHolder.GetComponent<Animation>().CrossFade("Walk");
											}
											else
											{
												animationHolder.GetComponent<Animation>().CrossFade("idle");
											}
											if (!grannyIsFollow)
											{
												navComponent.speed = 1.2f;
												if (navComponent.velocity != Vector3.zero)
												{
													animationHolder.GetComponent<Animation>().CrossFade("Walk");
													animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
												}
												else
												{
													animationHolder.GetComponent<Animation>().CrossFade("idle");
												}
											}
											else
											{
												navComponent.speed = grannysVarSpeed;
												if (navComponent.velocity != Vector3.zero)
												{
													animationHolder.GetComponent<Animation>().CrossFade("Walk");
													animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
												}
												else
												{
													animationHolder.GetComponent<Animation>().CrossFade("idle");
												}
											}
											seeClosedDoorTimer = 0f;
										}
									}
									seePlayerTimer = true;
								}
								else
								{
									seePlayerTimer = false;
									timerSee = 0f;
									safeTimer = 0f;
								}
							}
						}
						else if (hitInfo.collider.gameObject.tag == "Untagged")
						{
							grannySeeDoor = false;
							grannySeeLockedDoor = false;
							stopSeeLockedDoor = false;
							if (navComponent.velocity != Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Walk");
							}
						}
					}
				}
				else
				{
					grannySeeDoor = false;
					grannySeeLockedDoor = false;
					stopSeeLockedDoor = false;
					if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && navComponent.velocity != Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("Walk");
					}
				}
			}
			Vector3 vector = new Vector3(0f, -1f, 0f);
			if (Physics.Raycast(checkGround.transform.position, vector, out hitInfo, 5f))
			{
				Debug.DrawRay(checkGround.transform.position, vector, Color.yellow);
				if (hitInfo.collider.gameObject.name == "StairColliderC")
				{
					if (!seeStairs)
					{
						seeStairs = true;
						attackDistance = 4.5f;
					}
				}
				else if (hitInfo.collider.gameObject.name == "Golv" && seeStairs)
				{
					seeStairs = false;
					attackDistance = 4f;
					((GrannyFootstep)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = false;
				}
				if (hitInfo.collider.gameObject.tag == "grus")
				{
					((GrannyFootstep)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = true;
				}
				if (hitInfo.collider.gameObject.tag == "golv")
				{
					((GrannyFootstep)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = false;
				}
			}
		}
		if (distance < attackDistance && seePlayer && !grannyLookUnderBed && !playerHidingInCoffin && !playerHidingInCoffinBackyard && !playerHidingInCar && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !playerInHole && !playerGetCaught)
		{
			playerGetCaught = true;
			attackingPlayer = true;
			StartCoroutine(Playercaught());
			base.transform.LookAt(playerPos);
		}
		if (!playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			if (distanceWaypoint < 4f && playerHidingUnderBed && grannyIsFollow)
			{
				if (!grannyLookUnderBed && navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				navComponent.speed = 0f;
				facePlayerBed();
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingUnderBed)
				{
					optionButton.SetActive(value: false);
					animationHolder.GetComponent<Animation>().CrossFade("lookBed");
					grannyLookUnderBed = true;
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(value: false);
					if (hidingUnderBed1)
					{
						((bedEyes)bedCam1.GetComponent(typeof(bedEyes))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)soundHolder1.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					if (hidingUnderBed2)
					{
						((bedEyes2)bedCam2.GetComponent(typeof(bedEyes2))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)soundHolder2.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					if (hidingUnderBed3)
					{
						((bedEyes3)bedCam3.GetComponent(typeof(bedEyes3))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)soundHolder3.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					StartCoroutine(((playerCaughtUnderBed)gameController.GetComponent(typeof(playerCaughtUnderBed))).EndDayUnderBed());
					soundPlaying = false;
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCoffin && grannyIsFollow)
			{
				navComponent.speed = 0f;
				facePlayerBed();
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingInCoffin)
				{
					optionButton.SetActive(value: false);
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(value: false);
					StartCoroutine(Playercaught());
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCoffinBackyard && grannyIsFollow)
			{
				navComponent.speed = 0f;
				facePlayerBed();
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingInCoffinBackyard)
				{
					optionButton.SetActive(value: false);
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(value: false);
					StartCoroutine(Playercaught());
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCar && grannyIsFollow && grannyStandBesideCar)
			{
				if (!((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).carMoving)
				{
					navComponent.speed = 0f;
					facePlayerBed();
					if (navComponent.velocity != Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
					if (!grannyLookUnderBed)
					{
						timerBed += Time.deltaTime;
					}
					if (timerBed >= 3f && playerHidingInCar)
					{
						optionButton.SetActive(value: false);
						timerBed = 0f;
						safeTimer = 0f;
						allBedButtons.SetActive(value: false);
						startCarButton.SetActive(value: false);
						forwardButton.SetActive(value: false);
						reverseButton.SetActive(value: false);
						StartCoroutine(Playercaught());
					}
				}
			}
			else if (!playerHidingUnderBed && !playerHidingInCoffin && !playerHidingInCoffinBackyard && !playerHidingInCar && grannyIsFollow)
			{
				followPlayer();
			}
			if (grannyHearPlayer && !seePlayer && !grannyIsFollow)
			{
				if ((bool)GameObject.Find("TempNav(Clone)Old"))
				{
					target = GameObject.Find("TempNav(Clone)").transform;
				}
				else
				{
					target = GameObject.Find("TempNav(Clone)").transform;
				}
				if (!grannySeeDoor && !grannySeeLockedDoor)
				{
					navComponent.speed = grannysVarSpeed;
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
				grannyHearObject = false;
				droppingBeartrap = false;
			}
			if (grannyHearObject && !seePlayer && !grannyIsFollow)
			{
				if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
				{
					if ((bool)GameObject.Find("TempNavObjects(Clone)"))
					{
						target = GameObject.Find("TempNavObjects(Clone)").transform;
					}
					else
					{
						target = nav1;
					}
				}
				else
				{
					target = GameObject.Find("TempNavObjects(Clone)").transform;
				}
				if (!grannySeeDoor && !grannySeeLockedDoor)
				{
					navComponent.speed = grannysVarSpeed;
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
				grannyHearPlayer = false;
				droppingBeartrap = false;
				if (!resetSafeTimer)
				{
					resetSafeTimer = true;
					safeTimer = 0f;
				}
			}
			if (playerHidingUnderBed && seePlayer && grannyIsFollow)
			{
				if (hidingUnderBed1)
				{
					target = bedtargetTemp1;
				}
				if (hidingUnderBed2)
				{
					target = bedtargetTemp2;
				}
				if (hidingUnderBed3)
				{
					target = bedtargetTemp3;
				}
				seePlayer = false;
				navComponent.stoppingDistance = 2f;
				droppingBeartrap = false;
			}
			else if (playerHidingInCoffin && seePlayer && grannyIsFollow)
			{
				target = coffintargetTemp4;
			}
			else if (playerHidingInCoffinBackyard && seePlayer && grannyIsFollow)
			{
				target = coffintargetTempBY;
			}
			else if (playerHidingInCar && seePlayer && grannyIsFollow)
			{
				target = cartargetTemp;
			}
			GrannyDecisions();
		}
		if (playerNearGranny && !playerGetCaught && !playerHiding)
		{
			Vector3 vector2 = playerPos.position - base.transform.position;
			float maxRadiansDelta = speed * Time.deltaTime;
			Vector3 forward = Vector3.RotateTowards(base.transform.forward, vector2, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward);
		}
		if (grannyInBastu && bastuswitchOn && bastuBomNere && !freeze)
		{
			bastuTimer -= Time.deltaTime;
			bastuDoorTimer -= Time.deltaTime;
			if (bastuTimer <= 0f)
			{
				grannyInBastu = false;
				bastuKilled = true;
				StartCoroutine(grannyHitByArrow());
			}
			if (!bastuTimeOff && bastuDoorTimer <= 0f)
			{
				bastuTimeOff = true;
				bastuDoor.gameObject.tag = "innerdoorLocked";
				bastuDoorCarv.carving = !base.enabled;
			}
		}
		if (grannyInBastu && !bastuswitchOn && bastuBomNere && !freeze)
		{
			if (!bastuTimeOff)
			{
				bastuDoorTimer -= Time.deltaTime;
				if (bastuDoorTimer <= 0f)
				{
					bastuTimeOff = true;
					bastuDoor.gameObject.tag = "innerdoorLocked";
					bastuDoorCarv.carving = !base.enabled;
					StartbastuSafeTimer = true;
				}
			}
			if (StartbastuSafeTimer)
			{
				bastuSafeTimer += Time.deltaTime;
				if (bastuSafeTimer >= 30f)
				{
					StartbastuSafeTimer = false;
					bastuDoor.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
				}
			}
		}
		if (grannyInBastu && !bastuswitchOn && !bastuBomNere)
		{
			bastuDoorTimer = 20f;
		}
		if (hitByPepper && !playerGetCaught)
		{
			huntPlayer = false;
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = false;
			}
			grannyLock.SetActive(value: true);
			seePlayer = false;
			grannyIsFollow = false;
			playerNearGranny = false;
			base.gameObject.GetComponent<Collider>().enabled = false;
			((EnemyEye)grannyEye.GetComponent(typeof(EnemyEye))).enabled = false;
			blindTimer -= Time.deltaTime;
			if (blindTimer < 0f)
			{
				base.gameObject.GetComponent<Collider>().enabled = true;
				((EnemyEye)grannyEye.GetComponent(typeof(EnemyEye))).enabled = true;
				grannyCloseTrigger.SetActive(value: false);
				grannyLock.SetActive(value: false);
				hitByPepper = false;
				blindTimer = 30f;
				grannyPepperReact = false;
			}
			if (!grannyPepperReact)
			{
				grannyPepperReact = true;
				grannyHitByPepper();
			}
		}
		else if (playerGetCaught && hitByPepper)
		{
			grannyLock.SetActive(value: false);
			base.gameObject.GetComponent<Collider>().enabled = true;
			((EnemyEye)grannyEye.GetComponent(typeof(EnemyEye))).enabled = true;
			blindTimer = 30f;
		}
		if (hitByPepperStart && !animationHolder.GetComponent<Animation>().IsPlaying("pepperHit") && !animationHolder.GetComponent<Animation>().IsPlaying("pepperHit"))
		{
			hitByPepperStart = false;
			pepperAnimDone();
		}
	}

	public virtual void grannyHitByPepper()
	{
		navComponent.speed = 0f;
		animationHolder.GetComponent<Animation>().CrossFade("pepperHit");
	}

	public virtual void pepperAnimDone()
	{
		newNav();
	}

	public virtual IEnumerator grannyHitByArrow()
	{
		yield return new WaitForSeconds(3f);
		if (!((playerDead)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			UnityEngine.Object.Instantiate(grannyRagdoll, base.transform.position, base.transform.rotation);
			grannyDisaper.SetActive(value: false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				((GrannyGoneText)grannyGoneNormalText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				((GrannyGoneText)grannyGoneEasyText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				((GrannyGoneText)grannyGoneHardText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5)
			{
				((GrannyGoneText)grannyGoneExtremeText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
		}
	}

	public virtual void grannyHitByCar()
	{
		if (!((playerDead)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			UnityEngine.Object.Instantiate(grannyRagdoll, base.transform.position, base.transform.rotation);
			grannyDisaper.SetActive(value: false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				((GrannyGoneText)grannyGoneNormalText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				((GrannyGoneText)grannyGoneEasyText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				((GrannyGoneText)grannyGoneHardText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5)
			{
				((GrannyGoneText)grannyGoneExtremeText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
		}
	}

	public virtual void grannyHitByGun()
	{
		if (!((playerDead)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			UnityEngine.Object.Instantiate(grannyForceRagdoll, base.transform.position, base.transform.rotation);
			grannyDisaper.SetActive(value: false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				((GrannyGoneText)grannyGoneNormalShotText.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				((GrannyGoneText)grannyGoneEasyShotText.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				((GrannyGoneText)grannyGoneHardShotText.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5)
			{
				((GrannyGoneText)grannyGoneExtremeShotText.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
		}
	}

	public virtual IEnumerator grannyFreeze()
	{
		yield return new WaitForSeconds(2.5f);
		if (!((playerDead)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			UnityEngine.Object.Instantiate(grannyFreezedoll, base.transform.position, base.transform.rotation);
			grannyDisaper.SetActive(value: false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				((GrannyGoneText)grannyGoneNormalText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				((GrannyGoneText)grannyGoneEasyText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				((GrannyGoneText)grannyGoneHardText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5)
			{
				((GrannyGoneText)grannyGoneExtremeText1.GetComponent(typeof(GrannyGoneText))).textOnOff = true;
			}
		}
	}

	public virtual IEnumerator dropBearTrap()
	{
		yield return new WaitForSeconds(10f);
		if (!grannyIsFollow && !hitByArrow && !hitByGun && !grannyInBastu && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			navComponent.speed = 0f;
			droppingBeartrap = true;
			yield return new WaitForSeconds(1f);
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				UnityEngine.Object.Instantiate(bearTrap, bearTrapSP.position, bearTrapSP.rotation);
			}
			else
			{
				UnityEngine.Object.Instantiate(bearTrapOrganic, bearTrapSP.position, bearTrapSP.rotation);
			}
			yield return new WaitForSeconds(1f);
			droppingBeartrap = false;
			navComponent.speed = 1.2f;
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			else
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && other.gameObject.tag == "Player" && !playerHiding)
		{
			playerNearGranny = true;
			target = player;
			GrannyGonnaSmack = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			GrannyGonnaSmack = false;
		}
	}

	public virtual void GrannyDecisions()
	{
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze)
		{
			return;
		}
		if (grannyIsFollow)
		{
			if (distance < 4f)
			{
				facePlayer();
			}
			else if (distance > 6f)
			{
				playerNearGranny = false;
			}
		}
		else if (distance > 6f && target != player && !GrannyGonnaSmack)
		{
			playerNearGranny = false;
		}
	}

	public virtual void facePlayer()
	{
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			Vector3 vector = target.position - base.transform.position;
			float maxRadiansDelta = speed * Time.deltaTime;
			Vector3 forward = Vector3.RotateTowards(base.transform.forward, vector, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward);
		}
	}

	public virtual void facePlayerBed()
	{
		float maxRadiansDelta = speed * Time.deltaTime;
		if (hidingUnderBed1)
		{
			Vector3 vector = bedtargetTemp1.position - base.transform.position;
			base.transform.LookAt(bedtargetTemp1);
			Vector3 forward = Vector3.RotateTowards(base.transform.forward, vector, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward);
		}
		if (hidingUnderBed2)
		{
			Vector3 vector2 = bedtargetTemp2.position - base.transform.position;
			base.transform.LookAt(bedtargetTemp2);
			Vector3 forward2 = Vector3.RotateTowards(base.transform.forward, vector2, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward2);
		}
		if (hidingUnderBed3)
		{
			Vector3 vector3 = bedtargetTemp3.position - base.transform.position;
			base.transform.LookAt(bedtargetTemp3);
			Vector3 forward3 = Vector3.RotateTowards(base.transform.forward, vector3, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward3);
		}
		if (hidingInCoffin4)
		{
			Vector3 vector4 = coffintargetTemp4.position - base.transform.position;
			base.transform.LookAt(coffintargetTemp4);
			Vector3 forward4 = Vector3.RotateTowards(base.transform.forward, vector4, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward4);
		}
		if (hidingInCoffinBY)
		{
			Vector3 vector5 = coffintargetTempBY.position - base.transform.position;
			base.transform.LookAt(coffintargetTempBY);
			Vector3 forward5 = Vector3.RotateTowards(base.transform.forward, vector5, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward5);
		}
		if (hidingInCar)
		{
			Vector3 vector6 = cartargetTemp.position - base.transform.position;
			base.transform.LookAt(cartargetTemp);
			Vector3 forward6 = Vector3.RotateTowards(base.transform.forward, vector6, maxRadiansDelta, 0f);
			base.transform.rotation = Quaternion.LookRotation(forward6);
		}
	}

	public virtual IEnumerator Playercaught()
	{
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze || playerInHole)
		{
			yield break;
		}
		if (playerCaughtLastTime)
		{
			if (!playerHidingUnderBed)
			{
				if (playerHidingInCoffin)
				{
					player.transform.position = PlayerCoffinPos.position;
					Player.SetActive(value: true);
					coffinHead1.SetActive(value: false);
					coffinLock.transform.localEulerAngles = new Vector3(-153.846f, 0f, 0f);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(value: false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)player.GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)player.GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						yield return new WaitForSeconds(0.6f);
						yield return new WaitForSeconds(0.3f);
						((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else if (playerHidingInCoffinBackyard)
				{
					player.transform.position = PlayerCoffinBYPos.position;
					Player.SetActive(value: true);
					coffinHead2.SetActive(value: false);
					coffinLockBY.transform.localEulerAngles = new Vector3(165.669f, 0f, 0f);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(value: false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)player.GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)player.GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						yield return new WaitForSeconds(0.6f);
						yield return new WaitForSeconds(0.3f);
						((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else if (playerHidingInCar)
				{
					player.transform.position = PlayerCarPos.position;
					Player.SetActive(value: true);
					carHead.SetActive(value: false);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(value: false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)player.GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)player.GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						((soundEffects)playerSounds.GetComponent(typeof(soundEffects))).CarOut();
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						playerStartCar = false;
						engineOnSound.SetActive(value: false);
						engineOffSound.SetActive(value: true);
						engineStartSound.SetActive(value: false);
						grannyStandBesideCar = false;
						ObjectHolder.SetActive(value: true);
						yield return new WaitForSeconds(0.6f);
						yield return new WaitForSeconds(0.3f);
						((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
						engineOffSound.SetActive(value: false);
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else
				{
					playerNearGranny = false;
					GrannyGonnaSmack = false;
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(value: false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)player.GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)player.GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						if (Spider.activeSelf)
						{
							((spiderControll)Spider.GetComponent(typeof(spiderControll))).grannyCaughtPlayer();
						}
						yield return new WaitForSeconds(0.6f);
						((soundEffects)playerSounds.GetComponent(typeof(soundEffects))).playerGetHit();
						yield return new WaitForSeconds(0.3f);
						((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
			}
		}
		else if (!playerHidingUnderBed)
		{
			((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
			playerHukaKnappParent.SetActive(value: false);
			if (navComponent.velocity == Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
			((playerCaught)player.GetComponent(typeof(playerCaught))).startFOV = true;
			((playerCaught)player.GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
			GrannyGonnaSmack = false;
		}
		navComponent.speed = 0f;
	}

	public virtual void followPlayer()
	{
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			droppingBeartrap = false;
			if (!grannySeeDoor && !grannySeeLockedDoor)
			{
				navComponent.speed = grannysVarSpeed;
			}
			navComponent.stoppingDistance = 2f;
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			else
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
			animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
			target = player;
			GrannySearching = false;
			startTimerSearch = false;
			timerSearch = 0f;
		}
	}

	public virtual void newNav()
	{
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze)
		{
			return;
		}
		droppingBeartrap = false;
		if (!grannyHearPlayer)
		{
			UnityEngine.Object.Destroy(GameObject.Find("TempNav(Clone)"));
			UnityEngine.Object.Destroy(GameObject.Find("TempNav(Clone)Old"));
		}
		if (!grannyHearObject)
		{
			if (GameObject.FindGameObjectsWithTag("noiseobject") != null)
			{
				NPoints = GameObject.FindGameObjectsWithTag("noiseobject");
				for (int i = 0; i < NPoints.Length; i++)
				{
					UnityEngine.Object.Destroy(NPoints[i]);
				}
			}
			StartCoroutine(cleaning());
		}
		animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
		navComponent.SetDestination(target.position);
		navComponent.speed = 1.2f;
		waypointWaitTime = false;
		safeTimer = 0f;
		if (number == 1f || number == 2f)
		{
			target = nav1;
		}
		if (number == 3f || number == 4f)
		{
			target = nav2;
		}
		if (number == 5f || number == 6f)
		{
			target = nav3;
		}
		if (number == 7f || number == 8f)
		{
			target = nav4;
		}
		if (number == 9f || number == 10f)
		{
			target = nav5;
		}
		if (number == 11f || number == 12f)
		{
			target = nav6;
		}
		if (number == 13f || number == 14f)
		{
			target = nav7;
		}
		if (number == 15f || number == 16f)
		{
			target = nav8;
		}
		if (number == 17f || number == 18f)
		{
			target = nav9;
		}
		if (number == 19f || number == 20f)
		{
			target = nav10;
		}
		if (number == 21f || number == 22f)
		{
			target = nav11;
		}
		if (number == 23f || number == 24f)
		{
			target = nav12;
		}
		if (number == 25f || number == 26f)
		{
			target = nav13;
		}
		if (number == 27f || number == 28f)
		{
			target = nav14;
		}
		if (number == 29f || number == 30f)
		{
			target = nav15;
		}
		if (number == 31f || number == 32f)
		{
			target = nav16;
		}
	}

	public virtual IEnumerator cleaning()
	{
		yield return new WaitForSeconds(15f);
		StartCoroutine(((furnitureControlls)gameController.GetComponent(typeof(furnitureControlls))).cleanUp());
	}

	public EnemyAIGranny()
	{
		offScreenDot = 0.8f;
		waypointStart = true;
		timerOnOff = true;
	}
}
