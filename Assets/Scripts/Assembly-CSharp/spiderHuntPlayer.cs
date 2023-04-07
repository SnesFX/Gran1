using System;
using UnityEngine;

[Serializable]
public class spiderHuntPlayer : MonoBehaviour
{
	public GameObject Spider;

	public GameObject largeTrigger;

	public GameObject startTrigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
		{
			largeTrigger.SetActive(value: true);
			startTrigger.SetActive(value: false);
		}
	}
}
