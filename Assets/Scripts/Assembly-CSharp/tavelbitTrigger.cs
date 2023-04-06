using System;
using UnityEngine;

[Serializable]
public class tavelbitTrigger : MonoBehaviour
{
	public GameObject gameController;

	public GameObject tb1Ram;

	public GameObject tb2Ram;

	public GameObject tb3Ram;

	public GameObject tb4Ram;

	public GameObject tb1Hand;

	public GameObject tb2Hand;

	public GameObject tb3Hand;

	public GameObject tb4Hand;

	public GameObject dropObjectButton;

	public GameObject mittenRing;

	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb1)
			{
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb1 = false;
				((startNewDay)gameController.GetComponent(typeof(startNewDay))).tavelbit1 = true;
				tb1Ram.SetActive(value: true);
				tb1Hand.SetActive(value: false);
				dropObjectButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb2)
			{
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb2 = false;
				((startNewDay)gameController.GetComponent(typeof(startNewDay))).tavelbit2 = true;
				tb2Ram.SetActive(value: true);
				tb2Hand.SetActive(value: false);
				dropObjectButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb3)
			{
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb3 = false;
				((startNewDay)gameController.GetComponent(typeof(startNewDay))).tavelbit3 = true;
				tb3Ram.SetActive(value: true);
				tb3Hand.SetActive(value: false);
				dropObjectButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
			else if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb4)
			{
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).havetb4 = false;
				((startNewDay)gameController.GetComponent(typeof(startNewDay))).tavelbit4 = true;
				tb4Ram.SetActive(value: true);
				tb4Hand.SetActive(value: false);
				dropObjectButton.SetActive(value: false);
				mittenRing.SetActive(value: false);
				((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			}
		}
	}
}
