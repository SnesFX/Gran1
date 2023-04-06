using System;
using UnityEngine;

[Serializable]
public class reverseCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject reverseButton;

	public GameObject outOffCarButton;

	public bool reverse1Played;

	public GameObject carReverseSound1;

	public GameObject engineOnSound;

	public GameObject frontCrashSound;

	public GameObject frontCrashSound2;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).carMoving = true;
			if (!reverse1Played)
			{
				carAnimation.GetComponent<Animation>().Play("CarReverse");
				reverseButton.SetActive(value: false);
				reverse1Played = true;
				outOffCarButton.SetActive(value: false);
				carReverseSound1.SetActive(value: true);
				engineOnSound.SetActive(value: false);
				frontCrashSound.SetActive(value: false);
				frontCrashSound2.SetActive(value: false);
				CarHitTriggers.SetActive(value: true);
				optionButton.SetActive(value: false);
			}
			else
			{
				carAnimation.GetComponent<Animation>().Play("CarReverse2");
				reverseButton.SetActive(value: false);
				outOffCarButton.SetActive(value: false);
				carReverseSound1.SetActive(value: true);
				engineOnSound.SetActive(value: false);
				frontCrashSound.SetActive(value: false);
				frontCrashSound2.SetActive(value: false);
				CarHitTriggers.SetActive(value: true);
				optionButton.SetActive(value: false);
			}
		}
	}
}
