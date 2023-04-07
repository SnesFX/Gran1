using System.Collections;
using UnityEngine;

public class organicBeartrap : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(StartAnim());
	}

	private IEnumerator StartAnim()
	{
		yield return new WaitForSeconds(2f);
		base.gameObject.GetComponent<Animation>().Play("BeartrapLive");
	}

	public virtual void Update()
	{
		if (((BearTrap)base.gameObject.GetComponent(typeof(BearTrap))).beartrapOn)
		{
			base.gameObject.GetComponent<Animation>().Stop("BeartrapLive");
		}
	}
}
