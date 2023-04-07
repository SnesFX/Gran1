using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class sprayPepper : MonoBehaviour
{
	public GameObject player;

	public GameObject spray;

	public GameObject soundHolder;

	public bool sprayTime;

	public GameObject checkSpray;

	public virtual void Start()
	{
		sprayTime = false;
	}

	public virtual void Update()
	{
		if (!Input.GetMouseButtonDown(0) || ((FirstPersonController_Egen)player.GetComponent(typeof(FirstPersonController_Egen))).menuEnabled)
		{
			return;
		}
		if (((checkSprayCounter)checkSpray.GetComponent(typeof(checkSprayCounter))).sprayCounter > 0f)
		{
			if (!sprayTime)
			{
				spray.SetActive(value: true);
				sprayTime = true;
				soundHolder.SetActive(value: true);
				((checkSprayCounter)checkSpray.GetComponent(typeof(checkSprayCounter))).sprayCounter -= 1f;
				StartCoroutine(time());
			}
		}
		else
		{
			((checkSprayCounter)checkSpray.GetComponent(typeof(checkSprayCounter))).checkingSpray();
		}
	}

	public virtual IEnumerator time()
	{
		yield return new WaitForSeconds(1f);
		spray.SetActive(value: false);
		sprayTime = false;
		soundHolder.SetActive(value: false);
	}
}
