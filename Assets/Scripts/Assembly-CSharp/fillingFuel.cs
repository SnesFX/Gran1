using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class fillingFuel : MonoBehaviour
{
	public int layerMask;

	public GameObject gameController;

	public bool playerHoldButton;

	public GameObject fillFuelButton;

	public GameObject fillFuelMeter;

	public Image fillFuealBar;

	public GameObject doorRay;

	public bool playerTaken;

	public bool playSound;

	public bool noMoreFill;

	public GameObject pickUpButton;

	public GameObject tanklockAnim;

	public GameObject fillingGasSoundHolder;

	public bool tanklockAnimPlayed;

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (noMoreFill)
		{
			return;
		}
		Vector3 direction = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, direction, out hitInfo, 4f, layerMask))
			{
				if (hitInfo.collider.gameObject.tag == "fueltankPlace")
				{
					if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegascan)
					{
						fillFuelMeter.SetActive(value: true);
						fillFuelButton.SetActive(value: true);
						if (playerHoldButton)
						{
							fillingGasSoundHolder.SetActive(value: true);
							if (!tanklockAnimPlayed)
							{
								tanklockAnimPlayed = true;
								tanklockAnim.GetComponent<Animation>().Play("tanklockOpen");
							}
							fillFuealBar.fillAmount += 0.1f * Time.deltaTime;
							if (fillFuealBar.fillAmount >= 1f)
							{
								((checkTheCar)gameController.GetComponent(typeof(checkTheCar))).fuelOK = true;
								fillFuelMeter.SetActive(value: false);
								fillFuelButton.SetActive(value: false);
								UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
								tanklockAnim.GetComponent<Animation>().Play("tanklockClose");
								fillingGasSoundHolder.SetActive(value: false);
							}
						}
						else
						{
							fillingGasSoundHolder.SetActive(value: false);
						}
					}
					else
					{
						pickUpButton.SetActive(value: true);
					}
				}
				else if (hitInfo.collider.gameObject.tag == "golv")
				{
					fillFuelButton.SetActive(value: false);
					fillFuelMeter.SetActive(value: false);
					playerHoldButton = false;
					fillingGasSoundHolder.SetActive(value: false);
				}
				else if (hitInfo.collider.gameObject.tag == "Untagged")
				{
					fillFuelButton.SetActive(value: false);
					fillFuelMeter.SetActive(value: false);
					playerHoldButton = false;
					fillingGasSoundHolder.SetActive(value: false);
				}
			}
			else
			{
				fillFuelButton.SetActive(value: false);
				fillFuelMeter.SetActive(value: false);
				playerHoldButton = false;
				fillingGasSoundHolder.SetActive(value: false);
			}
		}
		else
		{
			fillFuelButton.SetActive(value: false);
			fillFuelMeter.SetActive(value: false);
			playerHoldButton = false;
			fillingGasSoundHolder.SetActive(value: false);
		}
	}

	public fillingFuel()
	{
		layerMask = 256;
	}
}
