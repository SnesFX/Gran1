using System;
using UnityEngine;

[Serializable]
public class soundEffects : MonoBehaviour
{
	public AudioClip PCaught;

	public AudioClip PCaughtNightmare;

	public AudioClip exitDoorOpen;

	public AudioClip playerHit;

	public AudioClip hukaSig;

	public AudioClip stand;

	public AudioClip bedNer;

	public AudioClip bedUpp;

	public AudioClip manakin;

	public AudioClip crossbowShoot;

	public AudioClip crossbowLoad;

	public AudioClip inCoffin;

	public AudioClip OutCoffin;

	public AudioClip landSound;

	public AudioClip landBRSound;

	public AudioClip fallFloor;

	public AudioClip placeTavelbit;

	public AudioClip gunShot;

	public AudioClip inCar;

	public AudioClip outCar;

	public AudioClip shotgunLoad;

	public AudioClip shotgunEmpty;

	public AudioClip pickUpLoaded;

	public AudioClip remoteSound;

	public AudioClip pickupObject;

	public virtual void Start()
	{
	}

	public virtual void playerCaught()
	{
		AudioSource.PlayClipAtPoint(PCaught, base.transform.position);
	}

	public virtual void playerCaughtNightmare()
	{
		AudioSource.PlayClipAtPoint(PCaught, base.transform.position);
		AudioSource.PlayClipAtPoint(PCaughtNightmare, base.transform.position);
	}

	public virtual void openExitDoor()
	{
		AudioSource.PlayClipAtPoint(exitDoorOpen, base.transform.position);
	}

	public virtual void playerGetHit()
	{
		AudioSource.PlayClipAtPoint(playerHit, base.transform.position);
	}

	public virtual void hukarSig()
	{
		AudioSource.PlayClipAtPoint(hukaSig, base.transform.position);
	}

	public virtual void standUp()
	{
		AudioSource.PlayClipAtPoint(stand, base.transform.position);
	}

	public virtual void underBed()
	{
		AudioSource.PlayClipAtPoint(bedNer, base.transform.position);
	}

	public virtual void fromBed()
	{
		AudioSource.PlayClipAtPoint(bedUpp, base.transform.position);
	}

	public virtual void manakinLook()
	{
		AudioSource.PlayClipAtPoint(manakin, base.transform.position);
	}

	public virtual void CrossbowShoot()
	{
		AudioSource.PlayClipAtPoint(crossbowShoot, base.transform.position);
	}

	public virtual void CrossbowLoad()
	{
		AudioSource.PlayClipAtPoint(crossbowLoad, base.transform.position);
	}

	public virtual void CoffinIn()
	{
		AudioSource.PlayClipAtPoint(inCoffin, base.transform.position);
	}

	public virtual void CoffinUt()
	{
		AudioSource.PlayClipAtPoint(OutCoffin, base.transform.position);
	}

	public virtual void playerLandSound()
	{
		AudioSource.PlayClipAtPoint(landSound, base.transform.position);
	}

	public virtual void playerLandBRSound()
	{
		AudioSource.PlayClipAtPoint(landBRSound, base.transform.position);
	}

	public virtual void playerFallFloor()
	{
		AudioSource.PlayClipAtPoint(fallFloor, base.transform.position);
	}

	public virtual void tavelbitPlace()
	{
		AudioSource.PlayClipAtPoint(placeTavelbit, base.transform.position);
	}

	public virtual void GunShoot()
	{
		AudioSource.PlayClipAtPoint(gunShot, base.transform.position);
	}

	public virtual void CarIn()
	{
		AudioSource.PlayClipAtPoint(inCar, base.transform.position);
	}

	public virtual void CarOut()
	{
		AudioSource.PlayClipAtPoint(outCar, base.transform.position);
	}

	public virtual void loadShotgun()
	{
		AudioSource.PlayClipAtPoint(shotgunLoad, base.transform.position);
	}

	public virtual void emptyShotgun()
	{
		AudioSource.PlayClipAtPoint(shotgunEmpty, base.transform.position);
	}

	public virtual void loadedPickup()
	{
		AudioSource.PlayClipAtPoint(pickUpLoaded, base.transform.position);
	}

	public virtual void clickRemote()
	{
		AudioSource.PlayClipAtPoint(remoteSound, base.transform.position);
	}

	public virtual void pickingUpStuff()
	{
		AudioSource.PlayClipAtPoint(pickupObject, base.transform.position);
	}
}
