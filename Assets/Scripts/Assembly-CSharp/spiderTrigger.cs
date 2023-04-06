using System;
using UnityEngine;

[Serializable]
public class spiderTrigger : MonoBehaviour
{
	public GameObject Spider;

	public GameObject spiderbackOfPoint;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player" && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer && !((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = true;
			spiderbackOfPoint.SetActive(value: true);
		}
	}
}
