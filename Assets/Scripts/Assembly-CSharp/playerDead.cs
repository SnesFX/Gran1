using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerDead : MonoBehaviour
{
	public Image blackScreenTexture;

	public float fadeBlackSpeed;

	public GameObject cam1;

	public GameObject cam2;

	public GameObject endScene2;

	public GameObject PlayerendScene3;

	public GameObject player;

	public GameObject granny;

	public GameObject grannyOverPlayer;

	public GameObject grannyOverPlayerAnim;

	public Transform GrannyEndPos;

	public GameObject cellarDoor;

	public GameObject gameController;

	public GameObject bloodscreenEnd;

	public GameObject gameOverText;

	public Image gameOverTexture;

	public GameObject soundHolder;

	public GameObject musicHolder;

	public GameObject musicHolderNM;

	public GameObject BGnoiceHolder;

	public GameObject carEngineSound;

	public GameObject carEngineStart;

	public GameObject carCrashSound;

	public GameObject grannyLaughSound;

	public GameObject playerInBed;

	public bool endSceneRunning;

	public bool endSceneRunning2;

	public bool endSceneRunning3;

	public GameObject giljoAnimHolder;

	public GameObject giljoSoundHolder;

	public GameObject grannyAnimHolder;

	public GameObject grannyInCar;

	public GameObject Motorhuv;

	public GameObject Car;

	public GameObject carReverseSound;

	public GameObject carForwardSound;

	public GameObject carSensors;

	public GameObject carBumper;

	public Transform CarStartPos;

	public GameObject GameOverScene4;

	public virtual void Start()
	{
	}

	public virtual IEnumerator startEndScene()
	{
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning = true;
		playerInBed.SetActive(value: false);
		bloodscreenEnd.SetActive(value: true);
		soundHolder.SetActive(value: true);
		cam1.SetActive(value: true);
		cellarDoor.SetActive(value: false);
		granny.SetActive(value: false);
		granny.transform.position = GrannyEndPos.position;
		granny.transform.rotation = GrannyEndPos.rotation;
		granny.SetActive(value: true);
		musicHolder.SetActive(value: false);
		musicHolderNM.SetActive(value: false);
		blackScreenTexture.CrossFadeAlpha(0f, 2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(0.9f);
		((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
		yield return new WaitForSeconds(4f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.5f, ignoreTimeScale: false);
		yield return new WaitForSeconds(2f);
		player.SetActive(value: false);
		cam1.SetActive(value: false);
		cam2.SetActive(value: true);
		yield return new WaitForSeconds(1f);
		blackScreenTexture.CrossFadeAlpha(0f, 3.5f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3.2f);
		yield return new WaitForSeconds(4.1f);
		grannyOverPlayer.SetActive(value: true);
		grannyOverPlayerAnim.GetComponent<Animation>()["GrannyEnd"].speed = 3f;
		yield return new WaitForSeconds(0.7f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		gameOverText.SetActive(value: true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator startEndScene2()
	{
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning2 = true;
		playerInBed.SetActive(value: false);
		bloodscreenEnd.SetActive(value: true);
		BGnoiceHolder.SetActive(value: false);
		endScene2.SetActive(value: true);
		cellarDoor.SetActive(value: false);
		granny.SetActive(value: false);
		musicHolder.SetActive(value: false);
		musicHolderNM.SetActive(value: false);
		blackScreenTexture.CrossFadeAlpha(0f, 6f, ignoreTimeScale: false);
		yield return new WaitForSeconds(9.5f);
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyLooking");
		yield return new WaitForSeconds(2.1f);
		giljoSoundHolder.SetActive(value: true);
		giljoAnimHolder.GetComponent<Animation>().Play("giljotinOn");
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyPullGiljotin");
		yield return new WaitForSeconds(0.9f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.1f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		gameOverText.SetActive(value: true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator startEndScene3()
	{
		Car.SetActive(value: false);
		Car.transform.position = CarStartPos.position;
		Car.SetActive(value: true);
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning3 = true;
		playerInBed.SetActive(value: false);
		bloodscreenEnd.SetActive(value: true);
		PlayerendScene3.SetActive(value: true);
		cellarDoor.SetActive(value: false);
		granny.SetActive(value: false);
		musicHolder.SetActive(value: false);
		musicHolderNM.SetActive(value: false);
		carSensors.SetActive(value: false);
		if ((bool)GameObject.Find("CarBumper"))
		{
			carBumper.SetActive(value: false);
		}
		if ((bool)GameObject.Find("MotorhuvCar"))
		{
			Motorhuv.gameObject.GetComponent<Animation>().Play("motorhuvClose");
		}
		carEngineStart.SetActive(value: true);
		carEngineSound.SetActive(value: true);
		blackScreenTexture.CrossFadeAlpha(0f, 6f, ignoreTimeScale: false);
		yield return new WaitForSeconds(7.5f);
		grannyInCar.SetActive(value: true);
		yield return new WaitForSeconds(7f);
		Car.GetComponent<Animation>().Play("CarReverse");
		carReverseSound.SetActive(value: true);
		yield return new WaitForSeconds(5f);
		carForwardSound.SetActive(value: true);
		yield return new WaitForSeconds(0.3f);
		Car.GetComponent<Animation>().Play("CarForward");
		yield return new WaitForSeconds(0.7f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.1f, ignoreTimeScale: false);
		carCrashSound.SetActive(value: true);
		yield return new WaitForSeconds(3f);
		grannyLaughSound.SetActive(value: true);
		gameOverText.SetActive(value: true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public void startEndScene4()
	{
		if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
		}
		musicHolder.SetActive(value: false);
		musicHolderNM.SetActive(value: false);
		GameOverScene4.SetActive(value: true);
		blackScreenTexture.CrossFadeAlpha(0f, 6f, ignoreTimeScale: false);
	}

	public virtual IEnumerator gameOverNoGranny()
	{
		gameOverText.SetActive(value: true);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		((FetchAds)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}
}
