using System;
using UnityEngine;

[Serializable]
public class shootSpiderButton : MonoBehaviour
{
	public bool buttonShot;

	public GameObject luckaAnim;

	public GameObject spider;

	public GameObject spiderTrigger1;

	public GameObject spiderTrigger2;

	public GameObject leaveTrigger;

	public GameObject shootbutton;

	public GameObject foodPos;

	public GameObject spiderNestpos;

	public GameObject spiderStartpos;

	public AudioClip luckaFaller;

	public virtual void Start()
	{
	}

	public virtual void closeSpiderlucka()
	{
		if (buttonShot)
		{
			return;
		}
		if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				buttonShot = true;
				luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
				luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
				spiderNestpos.transform.localPosition = new Vector3(20.28f, 91.04f, -17.06f);
				spiderStartpos.transform.localPosition = new Vector3(22.68f, 90.5774f, -9.64f);
				((spiderControll)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(value: false);
				spiderTrigger2.SetActive(value: false);
			}
		}
		else
		{
			buttonShot = true;
			luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
			spider.SetActive(value: false);
			spiderTrigger1.SetActive(value: false);
			spiderTrigger2.SetActive(value: false);
			leaveTrigger.SetActive(value: false);
			foodPos.SetActive(value: false);
			spiderNestpos.SetActive(value: false);
			shootbutton.SetActive(value: false);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (buttonShot || !(other.gameObject.tag == "arrow"))
		{
			return;
		}
		if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				buttonShot = true;
				luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
				luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
				spiderNestpos.transform.localPosition = new Vector3(22.49f, 91.04005f, -16f);
				spiderStartpos.transform.localPosition = new Vector3(22.68f, 90.5774f, -9.64f);
				((spiderControll)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(value: false);
				spiderTrigger2.SetActive(value: false);
				leaveTrigger.SetActive(value: false);
			}
		}
		else
		{
			buttonShot = true;
			luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
			spider.SetActive(value: false);
			spiderTrigger1.SetActive(value: false);
			spiderTrigger2.SetActive(value: false);
			leaveTrigger.SetActive(value: false);
			foodPos.SetActive(value: false);
			spiderNestpos.SetActive(value: false);
			shootbutton.SetActive(value: false);
		}
	}
}
