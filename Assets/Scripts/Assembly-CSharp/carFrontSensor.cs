using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carFrontSensor : MonoBehaviour
{
	public GameObject gameController;

	public GameObject forwardButton;

	public GameObject ReverseButton;

	public GameObject outOffCarButton;

	public bool garagedoorOpen;

	public float hitGaragedoorCounter;

	public GameObject brickWallStart;

	public GameObject brickWallBroken;

	public GameObject mittPrick;

	public Texture2D brokenTextureMin;

	public Texture2D brokenTextureMax;

	public GameObject camInCar;

	public GameObject escapeCam;

	public GameObject escapeCamNoGranny;

	public GameObject granny;

	public GameObject dust1;

	public GameObject dust2;

	public GameObject headAnim;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject crashSound;

	public GameObject crashSoundPort;

	public GameObject CarHitTriggers;

	public GameObject shouldOpenDoorFirstText;

	public GameObject optionButton;

	public bool textTimerOnOff;

	public float textTimer;

	public bool textShown;

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(value: false);
			}
		}
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (!(other.gameObject.tag == "car"))
		{
			yield break;
		}
		((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).reverseOK = true;
		((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).forwardOK = false;
		((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).carMoving = false;
		if (garagedoorOpen)
		{
			if (hitGaragedoorCounter == 1f)
			{
				brickWallStart.GetComponent<Renderer>().material.mainTexture = brokenTextureMax;
				hitGaragedoorCounter += 1f;
				dust2.SetActive(value: true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(value: false);
				engineOnSound.SetActive(value: true);
				crashSound.SetActive(value: true);
				CarHitTriggers.SetActive(value: false);
				yield return new WaitForSeconds(1f);
				forwardButton.SetActive(value: false);
				ReverseButton.SetActive(value: true);
				optionButton.SetActive(value: true);
				outOffCarButton.SetActive(value: true);
				carForwardSound.SetActive(value: false);
				engineOnSound.SetActive(value: true);
				crashSound.SetActive(value: true);
			}
			else if (hitGaragedoorCounter == 2f)
			{
				brickWallStart.SetActive(value: false);
				brickWallBroken.SetActive(value: true);
				mittPrick.SetActive(value: false);
				camInCar.SetActive(value: false);
				granny.SetActive(value: false);
				if (PlayerPrefs.GetInt("DiffData") == 4)
				{
					escapeCamNoGranny.SetActive(value: true);
					RenderSettings.fog = false;
					optionButton.SetActive(value: false);
					if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
					{
						UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				else
				{
					escapeCam.SetActive(value: true);
					RenderSettings.fog = false;
					optionButton.SetActive(value: false);
					if ((bool)GameObject.Find("GrannyRagdoll(Clone)"))
					{
						UnityEngine.Object.Destroy(GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				crashSound.SetActive(value: true);
				CarHitTriggers.SetActive(value: false);
			}
			else
			{
				hitGaragedoorCounter += 1f;
				brickWallStart.GetComponent<Renderer>().material.mainTexture = brokenTextureMin;
				dust1.SetActive(value: true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(value: false);
				engineOnSound.SetActive(value: true);
				crashSound.SetActive(value: true);
				CarHitTriggers.SetActive(value: false);
				yield return new WaitForSeconds(1f);
				forwardButton.SetActive(value: false);
				ReverseButton.SetActive(value: true);
				outOffCarButton.SetActive(value: true);
				optionButton.SetActive(value: true);
			}
		}
		else
		{
			headAnim.GetComponent<Animation>().Play("HeadForward");
			carForwardSound.SetActive(value: false);
			engineOnSound.SetActive(value: true);
			crashSoundPort.SetActive(value: true);
			CarHitTriggers.SetActive(value: false);
			yield return new WaitForSeconds(1f);
			forwardButton.SetActive(value: false);
			ReverseButton.SetActive(value: true);
			outOffCarButton.SetActive(value: true);
			optionButton.SetActive(value: true);
			if (!textShown)
			{
				textShown = true;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(value: true);
				textTimerOnOff = true;
			}
		}
	}
}
