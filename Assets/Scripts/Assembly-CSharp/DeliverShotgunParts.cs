using System;
using UnityEngine;

[Serializable]
public class DeliverShotgunParts : MonoBehaviour
{
	public GameObject gameController;

	public bool shotgunPart1;

	public bool shotgunPart2;

	public bool shotgunPart3;

	public GameObject shotgunPart1Table;

	public GameObject shotgunPart2Table;

	public GameObject shotgunPart3Table;

	public GameObject shotgunPart1Hand;

	public GameObject shotgunPart2Hand;

	public GameObject shotgunPart3Hand;

	public GameObject dropObjectButton;

	public GameObject Shotgun;

	public GameObject moreAmmo;

	public AudioClip placeObjectSound;

	public virtual void OnTriggerStay(Collider other)
	{
		if (!(other.gameObject.tag == "Player"))
		{
			return;
		}
		if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel1)
		{
			shotgunPart1Table.SetActive(value: true);
			shotgunPart1Hand.SetActive(value: false);
			dropObjectButton.SetActive(value: false);
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel1 = false;
			shotgunPart1 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart2 && shotgunPart3)
			{
				Shotgun.SetActive(value: true);
				moreAmmo.SetActive(value: true);
				shotgunPart1Table.SetActive(value: false);
				shotgunPart2Table.SetActive(value: false);
				shotgunPart3Table.SetActive(value: false);
			}
		}
		if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel2)
		{
			shotgunPart2Table.SetActive(value: true);
			shotgunPart2Hand.SetActive(value: false);
			dropObjectButton.SetActive(value: false);
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel2 = false;
			shotgunPart2 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart3)
			{
				Shotgun.SetActive(value: true);
				moreAmmo.SetActive(value: true);
				shotgunPart1Table.SetActive(value: false);
				shotgunPart2Table.SetActive(value: false);
				shotgunPart3Table.SetActive(value: false);
			}
		}
		if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel3)
		{
			shotgunPart3Table.SetActive(value: true);
			shotgunPart3Hand.SetActive(value: false);
			dropObjectButton.SetActive(value: false);
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).havegunDel3 = false;
			shotgunPart3 = true;
			GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart2)
			{
				Shotgun.SetActive(value: true);
				moreAmmo.SetActive(value: true);
				shotgunPart1Table.SetActive(value: false);
				shotgunPart2Table.SetActive(value: false);
				shotgunPart3Table.SetActive(value: false);
			}
		}
	}
}
