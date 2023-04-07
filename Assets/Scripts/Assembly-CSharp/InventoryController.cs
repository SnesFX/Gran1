using UnityEngine;

public class InventoryController : MonoBehaviour
{
	public GameObject Granny;

	public GameObject gameController;

	public GameObject mittenRing;

	public GameObject dropPoint;

	public GameObject dropPointFreezeTrap;

	public GameObject dropObjectButton;

	public GameObject arrowButton;

	public GameObject sprayButton;

	public GameObject useRemoteButton;

	public bool placeObject;

	public GameObject placeObjectButton;

	public bool plankaHighlighted;

	public GameObject highlightedPlanka;

	public GameObject highlightedPlankaTrigger;

	public GameObject plankaHole;

	public GameObject tb1;

	public Transform newtb1;

	public bool havetb1;

	public GameObject tb2;

	public Transform newtb2;

	public bool havetb2;

	public GameObject tb3;

	public Transform newtb3;

	public bool havetb3;

	public GameObject tb4;

	public Transform newtb4;

	public bool havetb4;

	public GameObject avbitare;

	public Transform newAvbitare;

	public bool haveAvbitare;

	public GameObject hammare;

	public Transform newHammare;

	public bool haveHammare;

	public GameObject vas;

	public Transform newvas;

	public bool havevas;

	public GameObject vas2;

	public Transform newvas2;

	public bool havevas2;

	public GameObject safeKey;

	public Transform newsafeKey;

	public bool havesafeKey;

	public GameObject exitKey;

	public Transform newexitKey;

	public bool haveexitKey;

	public GameObject hanglockKey;

	public Transform newhanglockKey;

	public bool havehanglockKey;

	public GameObject padlockCode;

	public Transform newpadlockCode;

	public bool havepadlockCode;

	public GameObject armborst;

	public Transform newarmborst;

	public bool havearmborst;

	public Transform newArrow;

	public bool haveArrow;

	public bool armborstArrowOK;

	public GameObject shootArrowRay;

	public GameObject weaponKey;

	public Transform newweaponKey;

	public bool haveweaponKey;

	public GameObject screwdriver;

	public Transform newscrewdriver;

	public bool havescrewdriver;

	public GameObject planka;

	public Transform newplanka;

	public bool haveplanka;

	public GameObject battery;

	public Transform newbattery;

	public bool havebattery;

	public GameObject playhouseKey;

	public Transform newplayhouseKey;

	public bool haveplayhouseKey;

	public GameObject carKey;

	public Transform newcarKey;

	public bool havecarKey;

	public GameObject melon;

	public Transform newmelon;

	public bool havemelon;

	public GameObject teddy;

	public Transform newteddy;

	public bool haveteddy;

	public GameObject kugg1;

	public Transform newkugg1;

	public bool havekugg1;

	public GameObject kugg2;

	public Transform newkugg2;

	public bool havekugg2;

	public GameObject message;

	public Transform newmessage;

	public bool havemessage;

	public GameObject brunnsvev;

	public Transform newbrunnsvev;

	public bool havebrunnsvev;

	public GameObject oldShotgun;

	public GameObject oldShotgunAnim;

	public Transform newoldShotgun;

	public bool haveoldShotgun;

	public bool oldShotgunLoaded;

	public GameObject shootButton;

	public GameObject shootRay;

	public GameObject ammo;

	public GameObject gunDel1;

	public Transform newgunDel1;

	public bool havegunDel1;

	public GameObject gunDel2;

	public Transform newgunDel2;

	public bool havegunDel2;

	public GameObject gunDel3;

	public Transform newgunDel3;

	public bool havegunDel3;

	public GameObject topplock;

	public Transform newtopplock;

	public bool havetopplock;

	public GameObject carbattery;

	public Transform newcarbattery;

	public bool havecarbattery;

	public GameObject gascan;

	public Transform newgascan;

	public bool havegascan;

	public GameObject wrench;

	public Transform newwrench;

	public bool havewrench;

	public GameObject sparkplug;

	public Transform newsparkplug;

	public bool havesparkplug;

	public GameObject meat;

	public Transform newmeat;

	public bool havemeat;

	public GameObject specialkey;

	public Transform newspecialkey;

	public bool havespecialkey;

	public GameObject book;

	public Transform newbook;

	public bool havebook;

	public GameObject pepperspray;

	public Transform newpepperspray;

	public bool havepepperspray;

	public GameObject remote;

	public Transform newremote;

	public bool haveremote;

	public GameObject birdSeed;

	public Transform newbirdSeed;

	public bool havebirdSeed;

	public GameObject freezeTrap;

	public Transform newfreezeTrap;

	public bool havefreezeTrap;

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

	public GameObject CantopenDoorYetText;

	public GameObject SomethingMissingHereText;

	public GameObject somethingInsideMelonText;

	public GameObject ShotgunLoadedText;

	public GameObject MaybePutSomethingHereText;

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

	public bool textTimerOnOff;

	public float textTimer;

	private void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoText();
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
			}
		}
	}

	public virtual void CheckInventory()
	{
		dropObjectButton.SetActive(value: false);
		if (haveAvbitare)
		{
			avbitare.SetActive(value: false);
			haveAvbitare = false;
			Object.Instantiate(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveHammare)
		{
			hammare.SetActive(value: false);
			haveHammare = false;
			Object.Instantiate(newHammare, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havevas)
		{
			vas.SetActive(value: false);
			havevas = false;
			Object.Instantiate(newvas, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havesafeKey)
		{
			safeKey.SetActive(value: false);
			havesafeKey = false;
			Object.Instantiate(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveexitKey)
		{
			exitKey.SetActive(value: false);
			haveexitKey = false;
			Object.Instantiate(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havehanglockKey)
		{
			hanglockKey.SetActive(value: false);
			havehanglockKey = false;
			Object.Instantiate(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havepadlockCode)
		{
			padlockCode.SetActive(value: false);
			havepadlockCode = false;
			Object.Instantiate(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havearmborst)
		{
			armborst.SetActive(value: false);
			havearmborst = false;
			arrowButton.SetActive(value: false);
			shootArrowRay.SetActive(value: false);
			Object.Instantiate(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation);
			if (armborstArrowOK)
			{
				Object.Instantiate(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
				haveArrow = false;
				armborstArrowOK = false;
			}
		}
		else if (haveweaponKey)
		{
			weaponKey.SetActive(value: false);
			haveweaponKey = false;
			Object.Instantiate(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havescrewdriver)
		{
			screwdriver.SetActive(value: false);
			havescrewdriver = false;
			Object.Instantiate(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveplanka)
		{
			planka.SetActive(value: false);
			haveplanka = false;
			Object.Instantiate(newplanka, dropPoint.transform.position, dropPoint.transform.rotation);
			placeObject = false;
			placeObjectButton.SetActive(value: false);
		}
		else if (havebattery)
		{
			battery.SetActive(value: false);
			havebattery = false;
			Object.Instantiate(newbattery, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havetb1)
		{
			tb1.SetActive(value: false);
			havetb1 = false;
			Object.Instantiate(newtb1, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havetb2)
		{
			tb2.SetActive(value: false);
			havetb2 = false;
			Object.Instantiate(newtb2, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havetb3)
		{
			tb3.SetActive(value: false);
			havetb3 = false;
			Object.Instantiate(newtb3, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havetb4)
		{
			tb4.SetActive(value: false);
			havetb4 = false;
			Object.Instantiate(newtb4, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havevas2)
		{
			vas2.SetActive(value: false);
			havevas2 = false;
			Object.Instantiate(newvas2, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveplayhouseKey)
		{
			playhouseKey.SetActive(value: false);
			haveplayhouseKey = false;
			Object.Instantiate(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havemelon)
		{
			melon.SetActive(value: false);
			havemelon = false;
			Object.Instantiate(newmelon, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveteddy)
		{
			teddy.SetActive(value: false);
			haveteddy = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			Object.Instantiate(newteddy, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havekugg1)
		{
			kugg1.SetActive(value: false);
			havekugg1 = false;
			Object.Instantiate(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havekugg2)
		{
			kugg2.SetActive(value: false);
			havekugg2 = false;
			Object.Instantiate(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havemessage)
		{
			message.SetActive(value: false);
			havemessage = false;
			Object.Instantiate(newmessage, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havebrunnsvev)
		{
			brunnsvev.SetActive(value: false);
			havebrunnsvev = false;
			Object.Instantiate(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveoldShotgun)
		{
			oldShotgun.SetActive(value: false);
			haveoldShotgun = false;
			shootButton.SetActive(value: false);
			shootRay.SetActive(value: false);
			Object.Instantiate(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havegunDel1)
		{
			gunDel1.SetActive(value: false);
			havegunDel1 = false;
			Object.Instantiate(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havegunDel2)
		{
			gunDel2.SetActive(value: false);
			havegunDel2 = false;
			Object.Instantiate(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havegunDel3)
		{
			gunDel3.SetActive(value: false);
			havegunDel3 = false;
			Object.Instantiate(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havecarKey)
		{
			carKey.SetActive(value: false);
			havecarKey = false;
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
			Object.Instantiate(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havetopplock)
		{
			topplock.SetActive(value: false);
			havetopplock = false;
			Object.Instantiate(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havecarbattery)
		{
			carbattery.SetActive(value: false);
			havecarbattery = false;
			Object.Instantiate(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havegascan)
		{
			gascan.SetActive(value: false);
			havegascan = false;
			Object.Instantiate(newgascan, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havewrench)
		{
			wrench.SetActive(value: false);
			havewrench = false;
			Object.Instantiate(newwrench, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havesparkplug)
		{
			sparkplug.SetActive(value: false);
			havesparkplug = false;
			Object.Instantiate(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havemeat)
		{
			meat.SetActive(value: false);
			havemeat = false;
			Object.Instantiate(newmeat, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havespecialkey)
		{
			specialkey.SetActive(value: false);
			havespecialkey = false;
			Object.Instantiate(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havebook)
		{
			book.SetActive(value: false);
			havebook = false;
			Object.Instantiate(newbook, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havepepperspray)
		{
			pepperspray.SetActive(value: false);
			havepepperspray = false;
			sprayButton.SetActive(value: false);
			Object.Instantiate(newpepperspray, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (haveremote)
		{
			remote.SetActive(value: false);
			haveremote = false;
			useRemoteButton.SetActive(value: false);
			Object.Instantiate(newremote, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havebirdSeed)
		{
			birdSeed.SetActive(value: false);
			havebirdSeed = false;
			Object.Instantiate(newbirdSeed, dropPoint.transform.position, dropPoint.transform.rotation);
		}
		else if (havefreezeTrap)
		{
			freezeTrap.SetActive(value: false);
			havefreezeTrap = false;
			Object.Instantiate(newfreezeTrap, dropPointFreezeTrap.transform.position, dropPointFreezeTrap.transform.rotation);
		}
		textTimerOnOff = true;
	}

	public virtual void placePlankaHole()
	{
		if (plankaHighlighted)
		{
			plankaHighlighted = false;
			highlightedPlanka.SetActive(value: false);
			highlightedPlankaTrigger.SetActive(value: false);
			plankaHole.SetActive(value: true);
			planka.SetActive(value: false);
			haveplanka = false;
			placeObject = false;
			placeObjectButton.SetActive(value: false);
			dropObjectButton.SetActive(value: false);
			mittenRing.SetActive(value: false);
		}
	}

	public virtual void NoText()
	{
		NeedhangLockKeyText.SetActive(value: false);
		NeedhammerText.SetActive(value: false);
		NeedsafeKeyText.SetActive(value: false);
		NeedAvbitarTongText.SetActive(value: false);
		NeedHusnyckelText.SetActive(value: false);
		NeedpadlockCodeText.SetActive(value: false);
		NeedCrossbowText.SetActive(value: false);
		CantopenDoorYetText.SetActive(value: false);
		NeedweaponKeyText.SetActive(value: false);
		NeedscrewdriverText.SetActive(value: false);
		NeedbatteryText.SetActive(value: false);
		missinTavelbitarText.SetActive(value: false);
		NeedplayhouseKeyText.SetActive(value: false);
		cutThingsHereText.SetActive(value: false);
		SomethingMissingHereText.SetActive(value: false);
		somethingInsideMelonText.SetActive(value: false);
		NeedWinchhandleText.SetActive(value: false);
		NeedFindSwitchText.SetActive(value: false);
		NeedShotgunText.SetActive(value: false);
		ShotgunLoadedText.SetActive(value: false);
		NeedcarKeyText.SetActive(value: false);
		NeedCarBatteryText.SetActive(value: false);
		NeedGasolineText.SetActive(value: false);
		NeedEnginePartText.SetActive(value: false);
		NeedWrenchText.SetActive(value: false);
		NeedSparkPlugText.SetActive(value: false);
		emptyPlateText.SetActive(value: false);
		NeedSpecialKeyText.SetActive(value: false);
		NeedRemoteControlText.SetActive(value: false);
		MaybePutSomethingHereText.SetActive(value: false);
	}

	public virtual void NoObjectText()
	{
		mittenRing.SetActive(value: false);
		hangLockKeyText.SetActive(value: false);
		hammerText.SetActive(value: false);
		safeKeyText.SetActive(value: false);
		AvbitarTongText.SetActive(value: false);
		HusnyckelText.SetActive(value: false);
		padlockCodeText.SetActive(value: false);
		CrossbowText.SetActive(value: false);
		TranquilizerDartText.SetActive(value: false);
		weaponKeyText.SetActive(value: false);
		screwdriverText.SetActive(value: false);
		plankText.SetActive(value: false);
		batteryText.SetActive(value: false);
		tavelbitText.SetActive(value: false);
		playhouseKeyText.SetActive(value: false);
		melonText.SetActive(value: false);
		teddyText.SetActive(value: false);
		cogwheelText.SetActive(value: false);
		winchhandleText.SetActive(value: false);
		PartOfShotgunText.SetActive(value: false);
		ShotgunText.SetActive(value: false);
		AmmoText.SetActive(value: false);
		carKeyText.SetActive(value: false);
		EnginePartText.SetActive(value: false);
		SparkPlugText.SetActive(value: false);
		GasolineCanText.SetActive(value: false);
		CarBatteryText.SetActive(value: false);
		WrenchText.SetActive(value: false);
		MeatText.SetActive(value: false);
		specialKeyText.SetActive(value: false);
		bookText.SetActive(value: false);
		peppersprayText.SetActive(value: false);
		RemoteControlText.SetActive(value: false);
		BirdSeedText.SetActive(value: false);
		emptyBowlText.SetActive(value: false);
		freezeTrapText.SetActive(value: false);
	}
}
