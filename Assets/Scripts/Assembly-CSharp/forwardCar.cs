using System;
using UnityEngine;

[Serializable]
public class forwardCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject forwardButton;

	public GameObject outOffCarButton;

	public GameObject carSensorFront;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject backCrashSound;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public GameObject escapeMusic;

	public GameObject mainMusic;

	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).carMoving = true;
			if (((carFrontSensor)carSensorFront.GetComponent(typeof(carFrontSensor))).hitGaragedoorCounter == 2f)
			{
				carAnimation.GetComponent<Animation>().Play("CarEscape");
				forwardButton.SetActive(value: false);
				outOffCarButton.SetActive(value: false);
				carForwardSound.SetActive(value: true);
				optionButton.SetActive(value: false);
				escapeMusic.SetActive(value: true);
				mainMusic.SetActive(value: false);
			}
			else
			{
				carAnimation.GetComponent<Animation>().Play("CarForward");
				forwardButton.SetActive(value: false);
				outOffCarButton.SetActive(value: false);
				carForwardSound.SetActive(value: true);
				engineOnSound.SetActive(value: false);
				backCrashSound.SetActive(value: false);
				CarHitTriggers.SetActive(value: true);
				optionButton.SetActive(value: false);
			}
		}
	}
}
