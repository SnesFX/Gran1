using System;
using UnityEngine;

[Serializable]
public class placePlankaHole : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			((InventoryController)gameController.GetComponent(typeof(InventoryController))).placePlankaHole();
		}
	}
}
