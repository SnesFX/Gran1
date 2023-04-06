using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class spiderControll : MonoBehaviour
{
	public GameObject gameController;

	public bool playerCaught;

	public bool spiderDead;

	public GameObject spiderParent;

	public Transform spiderStartPosition;

	public Transform spiderPlayerPosition;

	public bool huntPlayer;

	public bool foodTime;

	public float spiderDeadTimer;

	public float spiderEatTimer;

	public float beforeBackToNestTimer;

	public bool spiderStartEat;

	public bool SpiderBitePlayer;

	public Transform PlayerPos;

	public GameObject Player;

	public GameObject Granny;

	public Transform FoodPlate;

	public float spiderSpeed;

	public Animator spider2AnimHolder;

	public GameObject foodCollider;

	public GameObject playerCollider;

	public float damping;

	public bool soundSeePlayed;

	public bool soundAttackPlayed;

	public bool spiderResetNow;

	public bool spiderRunToNest;

	public bool spiderBackoff;

	public bool spiderInNest;

	public GameObject soundEffectHolder;

	public GameObject playerHukaKnapp;

	public GameObject playerHukaKnappParent;

	public GameObject inactivateSpider;

	public GameObject inactivateSpiderTrigger;

	public GameObject spiderTrigger2;

	public GameObject meatOnPlate;

	public GameObject leavetrigger;

	public Transform spiderNestPosition;

	public Transform spiderNotHuntPosition;

	public virtual void Start()
	{
		spider2AnimHolder = spider2AnimHolder.gameObject.GetComponent<Animator>();
		spider2AnimHolder.Play("idle");
	}

	public virtual void Update()
	{
		if (!spiderDead)
		{
			if (!spiderResetNow)
			{
				if (huntPlayer && !playerCaught)
				{
					spiderInNest = false;
					base.transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
					Vector3 forward = PlayerPos.position - base.transform.position;
					forward.y = 0f;
					Quaternion b = Quaternion.LookRotation(forward);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * damping);
					foodCollider.SetActive(value: false);
					playerCollider.SetActive(value: true);
					running();
					if (!soundSeePlayed)
					{
						soundSeePlayed = true;
						((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderSeePlayer();
					}
				}
				if (foodTime)
				{
					spiderInNest = false;
					base.transform.Translate(Vector3.forward * Time.deltaTime * 10f);
					base.transform.LookAt(FoodPlate);
					foodCollider.SetActive(value: true);
					playerCollider.SetActive(value: false);
					running();
				}
			}
			if (spiderResetNow && !spiderStartEat && !huntPlayer)
			{
				base.transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
				Vector3 forward2 = spiderNotHuntPosition.position - base.transform.position;
				forward2.y = 0f;
				Quaternion b2 = Quaternion.LookRotation(forward2);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * damping);
				foodCollider.SetActive(value: true);
				playerCollider.SetActive(value: false);
				running();
			}
			if (spiderRunToNest && !spiderStartEat && !huntPlayer)
			{
				base.transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
				Vector3 forward3 = spiderNestPosition.position - base.transform.position;
				forward3.y = 0f;
				Quaternion b3 = Quaternion.LookRotation(forward3);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b3, Time.deltaTime * damping);
				foodCollider.SetActive(value: true);
				playerCollider.SetActive(value: false);
				running();
			}
		}
		if (spiderDead)
		{
			spiderDeadTimer -= Time.deltaTime;
			if (spiderDeadTimer <= 0f)
			{
				inactivateSpider.SetActive(value: false);
				inactivateSpiderTrigger.SetActive(value: false);
			}
		}
		if (spiderStartEat)
		{
			spiderEatTimer += Time.deltaTime;
			if (spiderEatTimer >= 10f)
			{
				spiderStartEat = false;
				spiderTrigger2.SetActive(value: true);
				meatOnPlate.SetActive(value: false);
				spiderRunToNest = true;
			}
		}
		if (spiderBackoff)
		{
			beforeBackToNestTimer += Time.deltaTime;
			if (beforeBackToNestTimer >= 7f)
			{
				spiderBackoff = false;
				beforeBackToNestTimer = 0f;
				spiderRunToNest = true;
			}
		}
	}

	public virtual void running()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("Walk");
		}
	}

	public virtual void attack()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("attack");
			playerDead();
		}
	}

	public virtual void idle()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("idle");
		}
	}

	public virtual void playerDead()
	{
		if (!spiderDead && !SpiderBitePlayer)
		{
			foodCollider.SetActive(value: false);
			SpiderBitePlayer = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
			((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
			huntPlayer = false;
			spider2AnimHolder.Play("attack");
			((playerCrawl)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
			playerHukaKnappParent.SetActive(value: false);
			if (!soundAttackPlayed)
			{
				soundAttackPlayed = true;
				((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderAttackPlayer();
				((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerBiten();
			}
			StartCoroutine(spiderToStartPos());
		}
	}

	public virtual IEnumerator spiderToStartPos()
	{
		if (!spiderDead)
		{
			yield return new WaitForSeconds(1f);
			spiderParent.transform.position = spiderPlayerPosition.position;
			spiderParent.transform.rotation = spiderPlayerPosition.rotation;
			yield return new WaitForSeconds(7f);
			spiderParent.transform.position = spiderStartPosition.position;
			spiderParent.transform.rotation = spiderStartPosition.rotation;
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(value: false);
			inactivateSpiderTrigger.SetActive(value: true);
			spider2AnimHolder.Play("idle");
		}
	}

	public virtual void grannyCaughtPlayer()
	{
		if (!spiderDead)
		{
			playerCaught = true;
			spider2AnimHolder.Play("idle");
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(value: false);
			inactivateSpiderTrigger.SetActive(value: true);
		}
	}

	public virtual void grannyCaughtPlayerReset()
	{
		spiderParent.transform.position = spiderStartPosition.position;
		spiderParent.transform.rotation = spiderStartPosition.rotation;
		playerCaught = false;
		huntPlayer = false;
		spider2AnimHolder.Play("idle");
	}

	public virtual void spiderIsDead()
	{
		spiderDead = true;
		spider2AnimHolder.Play("die");
		SpiderBitePlayer = false;
		soundSeePlayed = false;
		soundAttackPlayed = false;
		foodCollider.SetActive(value: false);
		playerCollider.SetActive(value: false);
		spiderTrigger2.SetActive(value: false);
		if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
		{
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
		}
		leavetrigger.SetActive(value: false);
		((spiderSoundEffects)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderDie();
	}

	public spiderControll()
	{
		spiderDeadTimer = 8f;
		spiderInNest = true;
	}
}
