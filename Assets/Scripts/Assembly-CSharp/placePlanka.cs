using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class placePlanka : MonoBehaviour
{
	public GameObject gameController;

	public GameObject highlightPlanka;

	public bool holeOpen;

	public bool startText;

	public GameObject PlaceButton;

	public GameObject text;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (!(other.gameObject.tag == "Player"))
		{
			return;
		}
		if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveplanka)
		{
			highlightPlanka.SetActive(value: true);
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = true;
			PlaceButton.SetActive(value: true);
			return;
		}
		highlightPlanka.SetActive(value: false);
		((InventoryController)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
		if ((bool)GameObject.FindWithTag("plankawalk") && holeOpen && !startText)
		{
			startText = true;
			StartCoroutine(textTimer());
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (((InventoryController)gameController.GetComponent(typeof(InventoryController))).haveplanka)
			{
				highlightPlanka.SetActive(value: true);
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = true;
				PlaceButton.SetActive(value: true);
			}
			else
			{
				highlightPlanka.SetActive(value: false);
				((InventoryController)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
			}
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			highlightPlanka.SetActive(value: false);
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
			PlaceButton.SetActive(value: false);
		}
	}

	public virtual IEnumerator textTimer()
	{
		yield return new WaitForSeconds(3f);
		text.SetActive(value: true);
		yield return new WaitForSeconds(3f);
		text.SetActive(value: false);
	}
}
