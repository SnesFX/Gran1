using UnityEngine;

public class SpiderBackoff : MonoBehaviour
{
	public GameObject Spider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Spider")
		{
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).spiderBackoff = true;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)Spider.GetComponent(typeof(spiderControll))).idle();
			base.gameObject.SetActive(value: false);
		}
	}
}
