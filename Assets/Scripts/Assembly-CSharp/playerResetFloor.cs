using System;
using UnityEngine;

[Serializable]
public class playerResetFloor : MonoBehaviour
{
	public GameObject player;

	public Transform playerResetPos;

	public GameObject Sound1;

	public GameObject Sound2;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "resetfloor")
		{
			player.transform.position = playerResetPos.position;
			((backgroundSound)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
			((backgroundSound)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		}
	}
}
