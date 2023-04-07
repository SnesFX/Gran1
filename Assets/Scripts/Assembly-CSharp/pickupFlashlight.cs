using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class pickupFlashlight : MonoBehaviour
{
	public int layerMask;

	public GameObject player;

	public GameObject gameController;

	public GameObject flashlightEtext;

	public GameObject flashlightText;

	public bool pickingFlashlight;

	public GameObject doorRay;

	public bool playerTaken;

	public GameObject soundHolder;

	public GameObject lightOnPlayerDarker1;

	public GameObject lightOnPlayerDarker2;

	public GameObject lightOnPlayerDarker3;

	public GameObject lightOnPlayerDarker4;

	public GameObject lightOnPlayerDarker5;

	public GameObject lightOnPlayerDarker6;

	public GameObject lightOnPlayerDarker7;

	public GameObject lightOnPlayerDarker8;

	public GameObject lightOnPlayerDarker9;

	public GameObject lightOnPlayerDarker10;

	private void Start()
	{
		layerMask = ~layerMask;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && !((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled && (bool)flashlightEtext)
		{
			pickingFlashlight = true;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 4f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "flashlight")
				{
					flashlightEtext.SetActive(value: true);
					flashlightText.SetActive(value: true);
					if (pickingFlashlight)
					{
						lightOnPlayerDarker1.SetActive(value: true);
						lightOnPlayerDarker2.SetActive(value: true);
						lightOnPlayerDarker3.SetActive(value: true);
						lightOnPlayerDarker4.SetActive(value: true);
						lightOnPlayerDarker5.SetActive(value: true);
						lightOnPlayerDarker6.SetActive(value: true);
						lightOnPlayerDarker7.SetActive(value: true);
						lightOnPlayerDarker8.SetActive(value: true);
						lightOnPlayerDarker9.SetActive(value: true);
						lightOnPlayerDarker10.SetActive(value: true);
						((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).pickingUpStuff();
						Object.Destroy(hitInfo.collider.gameObject);
						flashlightEtext.SetActive(value: false);
						pickingFlashlight = false;
						flashlightText.SetActive(value: false);
						base.gameObject.SetActive(value: false);
					}
				}
				else
				{
					flashlightEtext.SetActive(value: false);
					flashlightText.SetActive(value: false);
					pickingFlashlight = false;
				}
			}
			else
			{
				flashlightEtext.SetActive(value: false);
				flashlightText.SetActive(value: false);
				pickingFlashlight = false;
			}
		}
		else
		{
			flashlightEtext.SetActive(value: false);
			flashlightText.SetActive(value: false);
			pickingFlashlight = false;
		}
	}
}
