using System.Collections;
using UnityEngine;

public class CrowControl : MonoBehaviour
{
	public GameObject CrowBur;

	public GameObject CrowFlyAnim;

	public GameObject CrowFlyEat;

	public GameObject CrowFlyBack;

	public GameObject CrowEat;

	public GameObject BurDoor;

	public GameObject Seed;

	public GameObject seedPlate;

	public GameObject crowGone;

	public bool burdoorIsOpen;

	public Animator CrowAnimHolder;

	public bool CrowStartEat;

	public bool isFlying;

	public bool isAttacking;

	public bool playerSteal;

	public bool shootInBur;

	public bool crowGetShoot;

	public bool crowNotShotAgain;

	public GameObject GrannyHear;

	public Transform GrannyHearSP;

	public AudioClip crowShootLjud;

	private void Start()
	{
		CrowAnimHolder = CrowAnimHolder.gameObject.GetComponent<Animator>();
		CrowAnimHolder.Play("CrowIdle");
	}

	private void Update()
	{
		if (CrowStartEat && !isFlying)
		{
			isFlying = true;
			StartCoroutine(crowStartFly());
		}
		if (playerSteal && !isAttacking && !isFlying)
		{
			isAttacking = true;
			StartCoroutine(crowProtectItem());
		}
		if (shootInBur && !crowGetShoot && !isFlying)
		{
			crowGetShoot = true;
			StartCoroutine(crowStartFlyShoot());
		}
	}

	public virtual IEnumerator crowStartFly()
	{
		if (!burdoorIsOpen)
		{
			burdoorIsOpen = true;
			BurDoor.GetComponent<Animation>().Play("BurDoorOpen");
			BurDoor.gameObject.tag = "Untagged";
		}
		Seed.SetActive(value: true);
		CrowBur.SetActive(value: false);
		CrowFlyEat.SetActive(value: true);
		crowGone.SetActive(value: false);
		CrowFlyAnim.GetComponent<Animation>().CrossFade("FlyEat");
		yield return new WaitForSeconds(1.1f);
		CrowEat.SetActive(value: true);
		CrowFlyEat.SetActive(value: false);
		yield return new WaitForSeconds(3f);
		Seed.SetActive(value: false);
		yield return new WaitForSeconds(2f);
		CrowEat.SetActive(value: false);
		CrowFlyBack.SetActive(value: true);
		CrowFlyAnim.GetComponent<Animation>().CrossFade("CrowFlyBack");
		yield return new WaitForSeconds(1.1f);
		CrowFlyBack.SetActive(value: false);
		CrowBur.SetActive(value: true);
		crowGone.SetActive(value: true);
		CrowAnimHolder.Play("CrowIdle");
		isFlying = false;
		CrowStartEat = false;
		seedPlate.gameObject.tag = "birdseedplate";
	}

	public virtual IEnumerator crowProtectItem()
	{
		CrowAnimHolder.Play("Attack");
		yield return new WaitForSeconds(1.5f);
		CrowAnimHolder.Play("CrowIdle");
		isAttacking = false;
		playerSteal = false;
		Object.Instantiate(GrannyHear, GrannyHearSP.position, GrannyHearSP.rotation);
	}

	public virtual IEnumerator crowStartFlyShoot()
	{
		if (!crowNotShotAgain)
		{
			crowNotShotAgain = true;
			if (!burdoorIsOpen)
			{
				burdoorIsOpen = true;
				BurDoor.GetComponent<Animation>().Play("BurDoorOpen");
				BurDoor.gameObject.tag = "Untagged";
			}
			CrowBur.SetActive(value: false);
			CrowFlyEat.SetActive(value: true);
			GetComponent<AudioSource>().PlayOneShot(crowShootLjud, 0.7f);
			CrowFlyAnim.GetComponent<Animation>().CrossFade("crowShootOut");
			yield return new WaitForSeconds(0.3f);
			CrowFlyAnim.GetComponent<Animation>().CrossFade("crowShootIn");
			CrowFlyEat.SetActive(value: false);
			CrowFlyBack.SetActive(value: true);
			yield return new WaitForSeconds(0.3f);
			CrowFlyBack.SetActive(value: false);
			CrowBur.SetActive(value: true);
			CrowAnimHolder.Play("CrowIdle");
			crowGetShoot = false;
			shootInBur = false;
		}
		else if (crowNotShotAgain)
		{
			GetComponent<AudioSource>().PlayOneShot(crowShootLjud, 0.7f);
			crowGetShoot = false;
			shootInBur = false;
		}
	}
}
