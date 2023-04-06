using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[Serializable]
public class shootGun : MonoBehaviour
{
	public GameObject SeeRay1;

	public GameObject Granny;

	public GameObject player;

	public GameObject playerShootAnim;

	public bool shooting;

	public GameObject shootButton;

	public int power;

	public GameObject ammoCheckHolder;

	public GameObject shotgunAnim;

	public GameObject soundHolder;

	public Transform grannyHearSound;

	public GameObject noiceDP;

	public Vector3 velocity;

	public GameObject Spider;

	public GameObject rat1;

	public GameObject rat2;

	public GameObject crow;

	public GameObject crowBurDead;

	public GameObject crowEatDead;

	public GameObject Skjutplatta;

	public bool shootingOnGascan;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && ((PickUp)ammoCheckHolder.GetComponent(typeof(PickUp))).oldShotgunLoaded)
		{
			shooting = true;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 vector = SeeRay1.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(SeeRay1.transform.position, SeeRay1.transform.forward, Color.green);
		if (shooting)
		{
			shooting = false;
			shotgunAnim.GetComponent<Animation>().Play("Shoot");
			playerShootAnim.GetComponent<Animation>().Play("shootGun");
			shootButton.SetActive(value: false);
			((PickUp)ammoCheckHolder.GetComponent(typeof(PickUp))).oldShotgunLoaded = false;
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).GunShoot();
			UnityEngine.Object.Instantiate(grannyHearSound, noiceDP.transform.position, noiceDP.transform.rotation);
			if (!Physics.Raycast(SeeRay1.transform.position, vector, out hitInfo, 13f))
			{
				return;
			}
			if ((bool)hitInfo.rigidbody)
			{
				hitInfo.rigidbody.AddForceAtPosition(vector * power, hitInfo.point);
			}
			if (hitInfo.collider.gameObject.tag == "granny")
			{
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
				((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			}
			else if (hitInfo.collider.gameObject.tag == "beartrap")
			{
				((BearTrap)hitInfo.collider.gameObject.GetComponent(typeof(BearTrap))).beartrapShot = true;
			}
			else if (hitInfo.collider.gameObject.tag == "shootbutton")
			{
				((shootSpiderButton)hitInfo.collider.gameObject.GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
			}
			else if (hitInfo.collider.gameObject.tag == "spidernest")
			{
				if (!((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
				{
					((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				}
			}
			else if (hitInfo.collider.gameObject.tag == "Spider")
			{
				((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderIsDead();
			}
			else if (hitInfo.collider.gameObject.tag == "gascan")
			{
				if (!shootingOnGascan)
				{
					shootingOnGascan = true;
					((explode)hitInfo.collider.gameObject.GetComponent(typeof(explode))).explodeNow();
				}
			}
			else if (hitInfo.collider.gameObject.tag == "rat1")
			{
				((ratController)rat1.GetComponent(typeof(ratController))).Waittimer = 100f;
			}
			else if (hitInfo.collider.gameObject.tag == "rat2")
			{
				((ratController)rat2.GetComponent(typeof(ratController))).Waittimer = 100f;
			}
			else if (hitInfo.collider.gameObject.tag == "burdoor")
			{
				((CrowControl)crow.GetComponent(typeof(CrowControl))).shootInBur = true;
			}
			else if (hitInfo.collider.gameObject.tag == "crowbur")
			{
				crow.SetActive(value: false);
				crowBurDead.SetActive(value: true);
				if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
				{
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
				}
			}
			else if (hitInfo.collider.gameObject.tag == "croweat")
			{
				crow.SetActive(value: false);
				crowEatDead.SetActive(value: true);
				if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
				{
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
				}
			}
			else if (hitInfo.collider.gameObject.tag == "skjutplatta")
			{
				((SkjutplattaDoor)Skjutplatta.GetComponent(typeof(SkjutplattaDoor))).doorUnlocked = true;
			}
		}
		else
		{
			shooting = false;
		}
	}

	public shootGun()
	{
		power = 500;
	}
}
