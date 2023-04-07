using System;
using UnityEngine;

[Serializable]
public class MomTeleport : MonoBehaviour
{
	public GameObject mom;

	public Transform teleportPoint;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((AIfollow)mom.GetComponent(typeof(AIfollow))).seePlayer)
		{
			mom.SetActive(value: false);
			mom.transform.position = teleportPoint.position;
			mom.SetActive(value: true);
		}
	}
}
