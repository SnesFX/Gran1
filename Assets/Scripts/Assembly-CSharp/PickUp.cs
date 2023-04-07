using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class PickUp : MonoBehaviour
{
	public GameObject gameController;

	public GameObject Granny;

	public GameObject player;

	public Transform GrannyStartPos;

	public GameObject SeeRay;

	public int layerMask;

	public bool playerTaken;

	public bool pickUp;

	public bool dropObject;

	public bool placeObject;

	public bool readyPickUp;

	public GameObject pickUpButton;

	public GameObject dropPoint;

	public GameObject dropPointPlanka;

	public GameObject dropObjectButton;

	public GameObject placeObjectButton;

	public GameObject soundHolder;

	public GameObject SpraysoundHolder;

	public GameObject mittenRing;

	public GameObject avklipptKabelCellar;

	public GameObject avklipptKabelVind;

	public GameObject KabelVind;

	public GameObject avklipptKabel;

	public GameObject fan;

	public GameObject fanCollider;

	public bool playSound;

	public AudioClip klippKabel;

	public AudioClip taBortPlanka;

	public AudioClip doorLocked;

	public AudioClip safeDoordoorLocked;

	public AudioClip safeDoorOpen;

	public AudioClip vapenDoorOpen;

	public AudioClip hitCam;

	public AudioClip plockaUppObject;

	public AudioClip plockaUppNyckel;

	public AudioClip plockaUppCrossbow;

	public AudioClip placeBattery;

	public AudioClip pickUpTeddy;

	public AudioClip placebrunnsvev;

	public AudioClip placeMelon;

	public AudioClip drarIspak;

	public AudioClip meatPlate;

	public AudioClip vind2Dooropen;

	public AudioClip vind2Lockopen;

	public AudioClip pickUpGascan;

	public AudioClip skruva;

	public AudioClip fillSeed;

	public GameObject LampaDoor1;

	public GameObject LampaDoor2;

	public GameObject doorRayHolder;

	public GameObject Bom;

	public GameObject DdoorLock;

	public GameObject arrowButton;

	public GameObject arrowArmborst;

	public GameObject Armborstladdad;

	public GameObject ArmborstOladdad;

	public GameObject avbitare;

	public Transform newAvbitare;

	public GameObject hammare;

	public Transform newHammare;

	public GameObject vas;

	public Transform newvas;

	public GameObject vas2;

	public Transform newvas2;

	public GameObject safeKey;

	public Transform newsafeKey;

	public GameObject exitKey;

	public Transform newexitKey;

	public GameObject hanglockKey;

	public Transform newhanglockKey;

	public GameObject padlockCode;

	public Transform newpadlockCode;

	public GameObject armborst;

	public Transform newarmborst;

	public Transform newArrow;

	public GameObject shootArrowRay;

	public GameObject weaponKey;

	public Transform newweaponKey;

	public GameObject screwdriver;

	public Transform newscrewdriver;

	public GameObject planka;

	public Transform newplanka;

	public GameObject battery;

	public Transform newbattery;

	public GameObject playhouseKey;

	public Transform newplayhouseKey;

	public GameObject carKey;

	public Transform newcarKey;

	public GameObject melon;

	public Transform newmelon;

	public GameObject teddy;

	public Transform newteddy;

	public GameObject kugg1;

	public Transform newkugg1;

	public GameObject kugg2;

	public Transform newkugg2;

	public GameObject message;

	public Transform newmessage;

	public GameObject brunnsvev;

	public Transform newbrunnsvev;

	public GameObject oldShotgun;

	public GameObject oldShotgunAnim;

	public Transform newoldShotgun;

	public bool oldShotgunLoaded;

	public GameObject shootButton;

	public GameObject shootRay;

	public GameObject ammo;

	public GameObject gunDel1;

	public Transform newgunDel1;

	public GameObject gunDel2;

	public Transform newgunDel2;

	public GameObject gunDel3;

	public Transform newgunDel3;

	public GameObject topplock;

	public Transform newtopplock;

	public GameObject topplockInPlace;

	public GameObject carbattery;

	public Transform newcarbattery;

	public GameObject carbatteryInPlace;

	public GameObject gascan;

	public Transform newgascan;

	public GameObject wrench;

	public Transform newwrench;

	public GameObject sparkplug;

	public Transform newsparkplug;

	public GameObject sparkPlugInPlace;

	public GameObject sparkPlugCable;

	public GameObject meat;

	public Transform newmeat;

	public GameObject spider;

	public GameObject meatOnPlate;

	public GameObject spiderTrigger;

	public GameObject specialkey;

	public Transform newspecialkey;

	public GameObject specialkeyLock;

	public GameObject specialkeyDoor;

	public GameObject specialkeyInPlace;

	public GameObject book;

	public Transform newbook;

	public GameObject pepperspray;

	public Transform newpepperspray;

	public GameObject remote;

	public Transform newremote;

	public GameObject birdSeed;

	public Transform newbirdSeed;

	public GameObject freezeTrap;

	public Transform newfreezeTrap;

	public GameObject sprayButton;

	public GameObject sprayParticle;

	public GameObject useRemoteButton;

	public GameObject secretWall;

	public GameObject bookInPlace;

	public bool plankaHighlighted;

	public GameObject highlightedPlanka;

	public GameObject highlightedPlankaTrigger;

	public GameObject plankaHole;

	public GameObject skruvPlatta;

	public GameObject skruvPlattaOutside;

	public GameObject hangLockKeyText;

	public GameObject padlockCodeText;

	public GameObject hammerText;

	public GameObject safeKeyText;

	public GameObject AvbitarTongText;

	public GameObject HusnyckelText;

	public GameObject CrossbowText;

	public GameObject TranquilizerDartText;

	public GameObject weaponKeyText;

	public GameObject screwdriverText;

	public GameObject plankText;

	public GameObject batteryText;

	public GameObject tavelbitText;

	public GameObject playhouseKeyText;

	public GameObject melonText;

	public GameObject teddyText;

	public GameObject cogwheelText;

	public GameObject winchhandleText;

	public GameObject PartOfShotgunText;

	public GameObject ShotgunText;

	public GameObject AmmoText;

	public GameObject carKeyText;

	public GameObject EnginePartText;

	public GameObject SparkPlugText;

	public GameObject GasolineCanText;

	public GameObject CarBatteryText;

	public GameObject WrenchText;

	public GameObject MeatText;

	public GameObject specialKeyText;

	public GameObject bookText;

	public GameObject peppersprayText;

	public GameObject RemoteControlText;

	public GameObject BirdSeedText;

	public GameObject freezeTrapText;

	public GameObject ShotgunLoadedText;

	public GameObject NeedShotgunText;

	public GameObject NeedhangLockKeyText;

	public GameObject NeedpadlockCodeText;

	public GameObject NeedhammerText;

	public GameObject NeedsafeKeyText;

	public GameObject NeedAvbitarTongText;

	public GameObject NeedHusnyckelText;

	public GameObject NeedCrossbowText;

	public GameObject NeedweaponKeyText;

	public GameObject NeedscrewdriverText;

	public GameObject NeedbatteryText;

	public GameObject NeedplayhouseKeyText;

	public GameObject cutThingsHereText;

	public GameObject NeedWinchhandleText;

	public GameObject NeedFindSwitchText;

	public GameObject missinTavelbitarText;

	public GameObject NeedcarKeyText;

	public GameObject NeedCarBatteryText;

	public GameObject NeedSparkPlugText;

	public GameObject emptyPlateText;

	public GameObject emptyBowlText;

	public GameObject NeedEnginePartText;

	public GameObject NeedWrenchText;

	public GameObject NeedGasolineText;

	public GameObject NeedSpecialKeyText;

	public GameObject NeedRemoteControlText;

	public GameObject MaybePutSomethingHereText;

	public GameObject CantopenDoorYetText;

	public GameObject kamera;

	public GameObject kameraBroken;

	public GameObject kameraSeeTrigger;

	public GameObject galler;

	public GameObject gallerColliders;

	public bool playerInPrison;

	public GameObject prisonDoor;

	public GameObject batteryOnPlace;

	public GameObject batterySpak;

	public GameObject tb1;

	public Transform newtb1;

	public GameObject tb2;

	public Transform newtb2;

	public GameObject tb3;

	public Transform newtb3;

	public GameObject tb4;

	public Transform newtb4;

	public GameObject playhouseDoor;

	public GameObject giljoCutArea;

	public GameObject melonInPlace;

	public GameObject giljotin;

	public GameObject somethingInsideMelonText;

	public bool haveSeenMelonText;

	public bool kugg1OK;

	public bool kugg2OK;

	public GameObject playHouseLucka;

	public GameObject SomethingMissingHereText;

	public GameObject kugg1inPlace;

	public GameObject kugg2inPlace;

	public GameObject brunnsvevInPlace;

	public GameObject brunnsvevsHolder;

	public GameObject extremeLockOn;

	public GameObject extremeLockOff;

	public GameObject crow;

	public bool textTimerOnOff;

	public float textTimer;

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (!((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && readyPickUp)
			{
				pickUp = true;
			}
		}
		else if (Input.GetKeyUp(KeyCode.E))
		{
			readyPickUp = false;
			pickUp = false;
		}
		else if (Input.GetKeyDown(KeyCode.Space) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && dropObjectButton.activeSelf)
		{
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = SeeRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(SeeRay.transform.position, direction, out hitInfo, 5f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "avbitare")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					AvbitarTongText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveAvbitare = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						avbitare.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						AvbitarTongText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "hammer")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					hammerText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveHammare = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						hammare.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						hammerText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vas")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havevas = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						vas.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "vas2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havevas2 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						vas2.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "safekey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					safeKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havesafeKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						safeKey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						safeKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "exitkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					HusnyckelText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveexitKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						exitKey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						HusnyckelText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "hanglockkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					hangLockKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havehanglockKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						hanglockKey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						hangLockKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "dpadlockCode")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					padlockCodeText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havepadlockCode = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						padlockCode.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						padlockCodeText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "armborst")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					CrossbowText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havearmborst = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						armborst.SetActive(value: true);
						arrowButton.SetActive(value: false);
						arrowArmborst.SetActive(value: false);
						Armborstladdad.SetActive(value: false);
						ArmborstOladdad.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						CrossbowText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppCrossbow);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "arrow")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					TranquilizerDartText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						readyPickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havearmborst)
						{
							if (!((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveArrow)
							{
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveArrow = true;
								pickUp = false;
								readyPickUp = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								arrowButton.SetActive(value: true);
								shootArrowRay.SetActive(value: true);
								arrowArmborst.SetActive(value: true);
								Armborstladdad.SetActive(value: true);
								ArmborstOladdad.SetActive(value: false);
								mittenRing.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).armborstArrowOK = true;
								TranquilizerDartText.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).CrossbowLoad();
							}
							else if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveArrow)
							{
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveArrow = true;
								pickUp = false;
								readyPickUp = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								arrowButton.SetActive(value: true);
								shootArrowRay.SetActive(value: true);
								arrowArmborst.SetActive(value: true);
								Armborstladdad.SetActive(value: true);
								ArmborstOladdad.SetActive(value: false);
								mittenRing.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).armborstArrowOK = true;
								TranquilizerDartText.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								UnityEngine.Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							NeedCrossbowText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "weaponkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					weaponKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveweaponKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						weaponKey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						weaponKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "screwdriver")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					screwdriverText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						screwdriver.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						screwdriverText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "plankawalk")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					plankText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveplanka = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						planka.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						plankText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "battery")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					batteryText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebattery = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						battery.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						batteryText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					tavelbitText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb1 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb1.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						tavelbitText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					tavelbitText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb2 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb2.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						tavelbitText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb3")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					tavelbitText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb3 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb3.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						tavelbitText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "tb4")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					tavelbitText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb4 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						tb4.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						tavelbitText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "playhousekey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					playhouseKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveplayhouseKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						playhouseKey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						playhouseKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppNyckel);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "melon")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					melonText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemelon = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						melon.SetActive(value: true);
						textTimer = 0f;
						if (!haveSeenMelonText)
						{
							haveSeenMelonText = true;
							somethingInsideMelonText.SetActive(value: true);
							textTimerOnOff = true;
						}
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						melonText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "teddy")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					teddyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveteddy = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						teddy.SetActive(value: true);
						((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						teddyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(pickUpTeddy);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kugg1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					cogwheelText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg1 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						kugg1.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						cogwheelText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "kugg2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					cogwheelText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg2 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						kugg2.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						cogwheelText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "message")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemessage = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						message.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "brunnsvevpickup")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					winchhandleText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebrunnsvev = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						brunnsvev.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						winchhandleText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgun")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					ShotgunText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveoldShotgun = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						oldShotgun.SetActive(value: true);
						if (oldShotgunLoaded)
						{
							ammo.SetActive(value: true);
							oldShotgunAnim.GetComponent<Animation>().Play("Load");
							shootButton.SetActive(value: true);
							shootRay.SetActive(value: true);
							((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).loadedPickup();
						}
						else
						{
							oldShotgunAnim.GetComponent<Animation>().Play("OpenEmpty");
							shootButton.SetActive(value: false);
							shootRay.SetActive(value: false);
							ammo.SetActive(value: false);
							((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).emptyShotgun();
						}
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						ShotgunText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "ammo")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					AmmoText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveoldShotgun)
						{
							if (!oldShotgunLoaded)
							{
								oldShotgunLoaded = true;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								shootButton.SetActive(value: true);
								shootRay.SetActive(value: true);
								ammo.SetActive(value: true);
								oldShotgunAnim.GetComponent<Animation>().Play("Load");
								mittenRing.SetActive(value: false);
								AmmoText.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).loadShotgun();
							}
							else if (oldShotgunLoaded)
							{
								oldShotgunLoaded = true;
								ShotgunLoadedText.SetActive(value: true);
								textTimerOnOff = true;
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							NeedShotgunText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					PartOfShotgunText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel1 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel1.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						PartOfShotgunText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					PartOfShotgunText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel2 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel2.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						PartOfShotgunText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "shotgunp3")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					PartOfShotgunText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel3 = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gunDel3.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						PartOfShotgunText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "carkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					carKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havecarKey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						carKey.SetActive(value: true);
						((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = true;
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						carKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "topplock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					EnginePartText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetopplock = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						topplock.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						EnginePartText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "carbattery")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					CarBatteryText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havecarbattery = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						carbattery.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						CarBatteryText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "gascan")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					GasolineCanText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegascan = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						gascan.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						GasolineCanText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(pickUpGascan);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "wrench")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					WrenchText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havewrench = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						wrench.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						WrenchText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "sparkplug")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					SparkPlugText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havesparkplug = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						sparkplug.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						SparkPlugText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "meat")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					MeatText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemeat = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						meat.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						MeatText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "specialkey")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					specialKeyText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havespecialkey = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						specialkey.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						specialKeyText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "book")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					bookText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebook = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						book.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						bookText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "pepperspray")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					peppersprayText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havepepperspray = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						pepperspray.SetActive(value: true);
						((sprayPepper)sprayButton.GetComponent(typeof(sprayPepper))).sprayTime = false;
						sprayParticle.SetActive(value: false);
						sprayButton.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						peppersprayText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "remotecontrol")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					RemoteControlText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveremote = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						remote.SetActive(value: true);
						useRemoteButton.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						RemoteControlText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "birdseed")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					BirdSeedText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebirdSeed = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						birdSeed.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						BirdSeedText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "freezetrap")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					freezeTrapText.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).havefreezeTrap = true;
						UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
						freezeTrap.SetActive(value: true);
						dropObjectButton.SetActive(value: true);
						mittenRing.SetActive(value: false);
						freezeTrapText.SetActive(value: false);
						GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabel")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor1.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f);
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).lampa1ok = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							avklipptKabel.SetActive(value: true);
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(value: true);
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabelcellar")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor2.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f);
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).lampa2ok = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							avklipptKabelCellar.SetActive(value: true);
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "bluekabelvind")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								fan.GetComponent<Animation>().Stop("FanSpinn");
								fanCollider.SetActive(value: false);
							}
							UnityEngine.Object.Destroy(KabelVind);
							avklipptKabelVind.SetActive(value: true);
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedAvbitarTongText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "planka")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							if (!playSound)
							{
								if (((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort)
								{
									playSound = true;
									UnityEngine.Object.Destroy((HingeJoint)hitInfo.collider.gameObject.GetComponent(typeof(HingeJoint)));
									GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka2Bort = true;
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
									hitInfo.collider.gameObject.tag = "Untagged";
								}
								else
								{
									((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
									playSound = true;
									GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort = true;
								}
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedhammerText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "plankavind")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
							GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
							hitInfo.collider.gameObject.tag = "plankawalk";
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedhammerText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "exitdoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveexitKey)
						{
							if (!playSound)
							{
								playSound = true;
								StartCoroutine(((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).openExitdoor());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(doorLocked);
							NeedHusnyckelText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "hanglock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havehanglockKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((Rigidbody)Bom.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).hangLockBort = true;
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedhangLockKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "hanglockgarage")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havehanglockKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((openDoors)doorRayHolder.GetComponent(typeof(openDoors))).garageportLock = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedhangLockKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "phpadlock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveplayhouseKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								playhouseDoor.gameObject.tag = "innerdoorClosed";
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedplayhouseKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "dpadlock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havepadlockCode)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)hitInfo.collider.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								DdoorLock.GetComponent<Animation>().Play("DlockAnim");
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).DpadlockBort = true;
								GetComponent<AudioSource>().PlayOneShot(klippKabel);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedpadlockCodeText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "batteryholder")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebattery)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.GetComponent<Animation>().Play("BatteryLockOpen");
								((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).batteryLockOk = true;
								batterySpak.GetComponent<Animation>().Play("BattSpakOK");
								battery.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebattery = false;
								batteryOnPlace.SetActive(value: true);
								dropObjectButton.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(placeBattery);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							textTimerOnOff = true;
							NeedbatteryText.SetActive(value: true);
							batterySpak.GetComponent<Animation>().Play("BattSpakNotOK");
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "safedoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havesafeKey)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("safeDoorOpen");
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(safeDoorOpen);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							NeedsafeKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "vapenskopdoor")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveweaponKey)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("VapenDoorOpen");
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(vapenDoorOpen);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							NeedweaponKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "tavelbitar")
				{
					if (!((startNewDay)gameController.GetComponent(typeof(startNewDay))).allaTavelbitarOnPlace)
					{
						readyPickUp = true;
						mittenRing.SetActive(value: true);
						if (pickUp)
						{
							pickUp = false;
							missinTavelbitarText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					else
					{
						readyPickUp = false;
						mittenRing.SetActive(value: false);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "screw1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("Screw1Open");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv1 = true;
								StartCoroutine(((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw1Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "screw2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("Screw2Open");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv2 = true;
								StartCoroutine(((skruvplatta)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw2Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "camera")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							if (!playSound)
							{
								playSound = true;
								kamera.SetActive(value: false);
								kameraBroken.SetActive(value: true);
								if (!playerInPrison)
								{
									kameraSeeTrigger.SetActive(value: false);
									galler.GetComponent<Collider>().enabled = true;
									gallerColliders.SetActive(value: false);
								}
								hitInfo.collider.gameObject.tag = "Untagged";
								GetComponent<AudioSource>().PlayOneShot(hitCam);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							textTimerOnOff = true;
							NeedhammerText.SetActive(value: true);
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "giljocutarea")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemelon)
						{
							if (!playSound)
							{
								playSound = true;
								giljoCutArea.SetActive(value: false);
								melonInPlace.SetActive(value: true);
								((giljotinTrigger)giljotin.GetComponent(typeof(giljotinTrigger))).meloninPlace = true;
								GetComponent<AudioSource>().PlayOneShot(placeMelon);
								melon.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemelon = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(value: false);
								mittenRing.SetActive(value: false);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							cutThingsHereText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "stortkugg")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg1)
						{
							if (!playSound)
							{
								playSound = true;
								kugg1inPlace.SetActive(value: true);
								kugg1OK = true;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg1.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg1 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(value: false);
								mittenRing.SetActive(value: false);
								if (kugg2OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									hitInfo.collider.gameObject.tag = "Untagged";
								}
							}
						}
						else if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg2)
						{
							if (!playSound)
							{
								playSound = true;
								kugg2inPlace.SetActive(value: true);
								kugg2OK = true;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg2.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havekugg2 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(value: false);
								mittenRing.SetActive(value: false);
								if (kugg1OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									hitInfo.collider.gameObject.tag = "Untagged";
								}
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							SomethingMissingHereText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "brunn")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebrunnsvev)
						{
							if (!playSound)
							{
								playSound = true;
								brunnsvevInPlace.SetActive(value: true);
								readyPickUp = false;
								((playerVevar)brunnsvevsHolder.GetComponent(typeof(playerVevar))).vevInPlace = true;
								hitInfo.collider.gameObject.GetComponent<Collider>().enabled = false;
								GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								brunnsvev.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebrunnsvev = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(value: false);
								mittenRing.SetActive(value: false);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedWinchhandleText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv1 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw1Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv2 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw2Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout3")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv3 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw3Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "screwout4")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.GetComponent<Animation>().Play("ELscrew");
								hitInfo.collider.gameObject.tag = "Untagged";
								((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv4 = true;
								StartCoroutine(((skruvplattaOutside)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw4Bort());
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedscrewdriverText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "topplocksskruv")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havewrench)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar = ((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar + 1f;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								GetComponent<AudioSource>().PlayOneShot(skruva);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedWrenchText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "topplockPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetopplock)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).topplockOK = true;
								topplockInPlace.SetActive(value: true);
								topplock.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetopplock = false;
								dropObjectButton.SetActive(value: false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedEnginePartText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "carbatteryPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havecarbattery)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).batteryOK = true;
								carbatteryInPlace.SetActive(value: true);
								carbattery.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havecarbattery = false;
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								dropObjectButton.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedCarBatteryText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "fueltankPlace")
				{
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (!((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegascan && !playSound)
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							playSound = true;
							textTimer = 0f;
							NeedGasolineText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "sparkplugPlace")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havesparkplug)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).sparkplugOK = true;
								sparkPlugInPlace.SetActive(value: true);
								sparkPlugCable.SetActive(value: false);
								sparkplug.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havesparkplug = false;
								dropObjectButton.SetActive(value: false);
								GetComponent<AudioSource>().PlayOneShot(drarIspak);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedSparkPlugText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "platevind")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemeat)
						{
							if (!playSound)
							{
								playSound = true;
								if (spider.activeSelf)
								{
									((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = true;
								}
								GetComponent<AudioSource>().PlayOneShot(meatPlate);
								meatOnPlate.SetActive(value: true);
								spiderTrigger.SetActive(value: false);
								meat.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havemeat = false;
								dropObjectButton.SetActive(value: false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							emptyPlateText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "vind2lock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havespecialkey)
						{
							if (!playSound)
							{
								playSound = true;
								specialkeyLock.GetComponent<Animation>().Play("vind2LockOpen");
								specialkeyDoor.GetComponent<Animation>().Play("vind2DoorOpen");
								specialkeyLock.GetComponent<AudioSource>().PlayOneShot(vind2Lockopen);
								specialkeyDoor.GetComponent<AudioSource>().PlayOneShot(vind2Dooropen);
								specialkeyInPlace.SetActive(value: true);
								specialkey.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havespecialkey = false;
								dropObjectButton.SetActive(value: false);
								hitInfo.collider.gameObject.tag = "Untagged";
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							NeedSpecialKeyText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "bookplace")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebook)
						{
							if (!playSound)
							{
								playSound = true;
								secretWall.GetComponent<Animation>().Play("fakeWallMove");
								bookInPlace.SetActive(value: true);
								book.SetActive(value: false);
								((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebook = false;
								dropObjectButton.SetActive(value: false);
								hitInfo.collider.gameObject.tag = "Untagged";
								if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).freeze)
								{
									Granny.SetActive(value: false);
									Granny.transform.position = GrannyStartPos.position;
									Granny.SetActive(value: true);
								}
								((startNewDay)gameController.GetComponent(typeof(startNewDay))).slendrinaMomAppeard = true;
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							MaybePutSomethingHereText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "spak")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("Spak");
							hitInfo.collider.gameObject.tag = "Untagged";
							((CheckExitDoor)gameController.GetComponent(typeof(CheckExitDoor))).extremeLockOk = true;
							extremeLockOn.SetActive(value: false);
							extremeLockOff.SetActive(value: true);
							GetComponent<AudioSource>().PlayOneShot(drarIspak);
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "lockmotor")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
						pickUp = false;
						textTimer = 0f;
						NeedFindSwitchText.SetActive(value: true);
						textTimerOnOff = true;
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "remoteLock")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp && !((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveremote)
					{
						((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
						pickUp = false;
						textTimer = 0f;
						NeedRemoteControlText.SetActive(value: true);
						textTimerOnOff = true;
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "birdseedplate")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havebirdSeed)
						{
							if (!playSound)
							{
								playSound = true;
								hitInfo.collider.gameObject.tag = "Untagged";
								((CrowControl)crow.GetComponent(typeof(CrowControl))).CrowStartEat = true;
								GetComponent<AudioSource>().PlayOneShot(fillSeed);
							}
						}
						else
						{
							((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
							textTimer = 0f;
							emptyBowlText.SetActive(value: true);
							textTimerOnOff = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "sprint1")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("sprintAnim");
							hitInfo.collider.gameObject.tag = "Untagged";
							((prisonDoorOpenClose)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint1Bort = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "prisondoorlocked")
				{
					mittenRing.SetActive(value: false);
					pickUp = false;
				}
				else if (hitInfo.collider.gameObject.tag == "sprint2")
				{
					readyPickUp = true;
					mittenRing.SetActive(value: true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							hitInfo.collider.gameObject.GetComponent<Animation>().Play("sprintAnim");
							hitInfo.collider.gameObject.tag = "Untagged";
							((prisonDoorOpenClose)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint2Bort = true;
						}
					}
					audio();
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					readyPickUp = false;
					mittenRing.SetActive(value: false);
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else if (hitInfo.collider.gameObject.tag == "golv")
				{
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else if (hitInfo.collider.gameObject.tag == "grus")
				{
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else if (hitInfo.collider.gameObject.tag == "car")
				{
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else if (hitInfo.collider.gameObject.tag == "smalldoorLocked")
				{
					readyPickUp = false;
					RemoteControlText.SetActive(value: false);
				}
				else if (hitInfo.collider.gameObject.tag == "loda1Open")
				{
					readyPickUp = false;
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else if (hitInfo.collider.gameObject.tag == "loda2Open")
				{
					readyPickUp = false;
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
				else
				{
					((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
				}
			}
			else
			{
				readyPickUp = false;
				mittenRing.SetActive(value: false);
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
			}
		}
		else
		{
			readyPickUp = false;
		}
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
			}
		}
	}

	public virtual void audio()
	{
		playSound = false;
	}

	public PickUp()
	{
		layerMask = 256;
	}
}
