using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerFreeze : MonoBehaviour
{
	public Image FreezeScreen;

	public GameObject FreezeScreenTexture;

	public bool freezeON;

	public bool freezeOFF;

	public GameObject Granny;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject GrannyEye;

	public GameObject allBedButtons;

	public GameObject doorRay;

	public GameObject pickUpRay;

	public GameObject iceBreakSoundHolder;

	public bool playerStuckTimer;

	public float timerCount;

	private void Start()
	{
		FreezeScreen.canvasRenderer.SetAlpha(0f);
		timerCount = 10f;
	}

	private void Update()
	{
		if (playerStuckTimer)
		{
			timerCount -= Time.deltaTime;
			if (timerCount <= 0f)
			{
				playerStuckTimer = false;
				freezeOFF = true;
				timerCount = 10f;
				playerFreezeFree();
			}
		}
		if (freezeON)
		{
			FreezeScreen.CrossFadeAlpha(1f, 4f, ignoreTimeScale: false);
			if (FreezeScreen.canvasRenderer.GetAlpha() > 0.9f)
			{
				freezeON = false;
			}
		}
		if (freezeOFF)
		{
			FreezeScreen.CrossFadeAlpha(0f, 2f, ignoreTimeScale: false);
			if (FreezeScreen.canvasRenderer.GetAlpha() < 0.1f)
			{
				freezeOFF = false;
				FreezeScreen.canvasRenderer.SetAlpha(0f);
			}
		}
	}

	public virtual void playerFreezeStuck()
	{
		playerStuckTimer = true;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
		((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).bastuKilled && !((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).freeze && GrannyEye.activeSelf)
		{
			((EnemyEye)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
		}
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInFreezetrap = true;
		((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 0f;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
		((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
		allBedButtons.SetActive(value: false);
		doorRay.SetActive(value: false);
		pickUpRay.SetActive(value: false);
		freezeON = true;
	}

	public virtual void playerFreezeFree()
	{
		if (!((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			allBedButtons.SetActive(value: true);
			((deactivateIceBreakSound)iceBreakSoundHolder.GetComponent(typeof(deactivateIceBreakSound))).playIceBreak();
			((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).playerInFreezetrap = false;
			if (player.GetComponent<CharacterController>().height == 2.76f)
			{
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 6f;
			}
			else if (player.GetComponent<CharacterController>().height == 1.65f)
			{
				((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).m_WalkSpeed = 1f;
			}
		}
		doorRay.SetActive(value: true);
		pickUpRay.SetActive(value: true);
	}
}
