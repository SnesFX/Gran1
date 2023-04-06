using System.Collections;
using UnityEngine;

public class maybePlacePlankaText : MonoBehaviour
{
	public GameObject text;

	private void Start()
	{
		StartCoroutine(textTimer());
	}

	public virtual IEnumerator textTimer()
	{
		yield return new WaitForSeconds(3f);
		text.SetActive(value: true);
		yield return new WaitForSeconds(3f);
		text.SetActive(value: false);
	}
}
