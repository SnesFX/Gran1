using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class movHead : MonoBehaviour
{
	public Texture headR;

	public Texture headL;

	public Image head;

	private bool headMove;

	public virtual IEnumerator Start()
	{
		head.GetComponent<Image>().texture = headR;
		yield return new WaitForSeconds(10f);
		head.GetComponent<Image>().texture = headL;
		yield return new WaitForSeconds(10f);
		head.GetComponent<Image>().texture = headR;
		headMove = true;
	}

	public virtual void Update()
	{
		if (headMove)
		{
			headMove = false;
			StartCoroutine(moveHead());
		}
	}

	public virtual IEnumerator moveHead()
	{
		yield return new WaitForSeconds(10f);
		head.GetComponent<Image>().texture = headL;
		yield return new WaitForSeconds(10f);
		head.GetComponent<Image>().texture = headR;
		headMove = true;
	}
}
